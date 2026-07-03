using System.Net;
using System.Text.Json.Nodes;

namespace Deck_Randomiser_3;

public partial class RandomCard : UserControl
{
    private PictureBox cardImage;
    private Image image;
    private JsonNode _cardData;
    private Form _hoverPopup;

    public RandomCard()
    {
        InitializeComponent();
    }

    private void GetCard_Click(object sender, EventArgs e)
    {
        LoadCard(isCommander: false);
    }

    private void GetCommander_Click(object sender, EventArgs e)
    {
        LoadCard(isCommander: true);
    }

    private void LoadCard(bool isCommander)
    {
        cardImage?.Dispose();
        this.Controls.Remove(cardImage);
        HideCardPopup();

        try
        {
            _cardData = FetchRandomCard(isCommander);
            cardImage = BuildCardPictureBox(_cardData);
            this.Controls.Add(cardImage);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private string BuildQuery(bool isCommander)
    {
        var query = "";

        if (isCommander)
        {
            query += "is%3Acommander";
        }

        if (SearchCriteria.Text != "")
        {
            var lines = SearchCriteria.Text.Split("\n");
            foreach (var line in lines)
            {
                if (line == "") continue;
                var encodedLine = HtmlEncode(line);
                query += (query != "" ? "+" : "") + encodedLine;
            }
        }

        return query;
    }

    private JsonNode FetchRandomCard(bool isCommander)
    {
        using var client = new WebClient();
        client.Headers.Add(HttpRequestHeader.Accept, "*/*");
        client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");

        var query = BuildQuery(isCommander);
        var uri = "https://api.scryfall.com/cards/random";
        if (query != "")
        {
            uri += "?q=" + query;
        }

        var jsonString = client.DownloadString(uri);
        return JsonNode.Parse(jsonString);
    }

    private PictureBox BuildCardPictureBox(JsonNode card)
    {
        image?.Dispose();

        var imageUrl = card?["image_uris"]?["normal"]?.ToString()
                        ?? card?["card_faces"]?[0]?["image_uris"]?["normal"]?.ToString();

        if (imageUrl == null)
        {
            return new PictureBox();
        }

        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            client.DownloadFile(imageUrl, "cards.jpg");
        }

        image = Image.FromFile("cards.jpg");
        var pictureBox = new PictureBox
        {
            Location = new Point(40, 30),
            Image = image,
            SizeMode = PictureBoxSizeMode.StretchImage,
            Size = new Size(292, 408)
        };

        pictureBox.MouseEnter += (s, e) =>
        {
            if (_cardData != null)
            {
                var screenLoc = pictureBox.PointToScreen(new Point(pictureBox.Width, 0));
                ShowCardPopup(_cardData, screenLoc);
            }
        };
        pictureBox.MouseLeave += (s, e) => HideCardPopup();

        return pictureBox;
    }

    private string HtmlEncode(string text)
    {
        string encoded = text.Replace(" ", "+");
        encoded = encoded.Replace("<", "%3C");
        encoded = encoded.Replace("=", "%3D");
        encoded = encoded.Replace(">", "%3E");
        encoded = encoded.Replace("&", "%26");
        encoded = encoded.Replace(":", "%3A");
        encoded = encoded.Replace("/", "%2F");
        encoded = encoded.Replace("(", "%28");
        encoded = encoded.Replace(")", "%29");
        encoded = encoded.Replace("!", "%21");
        return encoded;
    }

    private void ShowCardPopup(JsonNode card, Point screenLocation)
    {
        _hoverPopup?.Close();

        const int maxWidth = 300;

        var nameText = card?["name"]?.ToString() ?? "(unknown name)";
        var manaCost = FormatManaCost(card);
        var oracleText = card?["oracle_text"]?.ToString()
                         ?? card?["card_faces"]?[0]?["oracle_text"]?.ToString()
                         ?? "";

        var panel = new FlowLayoutPanel
        {
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Padding = new Padding(8),
            BackColor = Color.LightYellow
        };

        var nameLabel = new Label
        {
            Text = nameText,
            Font = new Font(Font.FontFamily, 10, FontStyle.Bold),
            AutoSize = true,
            MaximumSize = new Size(maxWidth, 0),
            Margin = new Padding(0, 0, 0, 4)
        };
        panel.Controls.Add(nameLabel);

        if (!string.IsNullOrEmpty(manaCost))
        {
            var manaLabel = new Label
            {
                Text = manaCost,
                AutoSize = true,
                MaximumSize = new Size(maxWidth, 0),
                ForeColor = Color.DarkSlateGray,
                Margin = new Padding(0, 0, 0, 6)
            };
            panel.Controls.Add(manaLabel);
        }

        var oracleLabel = new Label
        {
            Text = oracleText,
            AutoSize = true,
            MaximumSize = new Size(maxWidth, 0),
            Margin = new Padding(0)
        };
        panel.Controls.Add(oracleLabel);

        _hoverPopup = new Form
        {
            FormBorderStyle = FormBorderStyle.None,
            StartPosition = FormStartPosition.Manual,
            Location = screenLocation,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            BackColor = Color.Ivory,
            TopMost = true,
            ShowInTaskbar = false
        };

        _hoverPopup.Controls.Add(panel);
        _hoverPopup.Show();
    }
    
    private string FormatManaCost(JsonNode card)
    {
        var manaCost = card?["mana_cost"]?.ToString();

        // Double-faced cards often have mana_cost empty at top level
        if (string.IsNullOrEmpty(manaCost))
        {
            manaCost = card?["card_faces"]?[0]?["mana_cost"]?.ToString();
        }

        if (string.IsNullOrEmpty(manaCost))
            return "";

        return manaCost.Replace("{", "").Replace("}", " ").Trim();
    }

    private void HideCardPopup()
    {
        _hoverPopup?.Close();
        _hoverPopup = null;
    }
}