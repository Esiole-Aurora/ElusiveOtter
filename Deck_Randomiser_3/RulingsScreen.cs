using System.Net;
using System.Text.Json.Nodes;

namespace Deck_Randomiser_3;

public partial class RulingsScreen : UserControl
{
    private Image _image = null;
    private PictureBox _cardImage = null;
    
    public RulingsScreen()
    {
        InitializeComponent();
    }
    
    private void Scryfall_GetRuling()
    {
        using var client = new WebClient();
        client.Headers.Add(HttpRequestHeader.Accept, "*/*");
        client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
        var uri = "https://api.scryfall.com/cards/";
        uri += CardName.Text;
        uri += "/rulings";
        try
        {
            client.DownloadFile(uri, "cardrulings.json");
        }
        catch (Exception e)
        {
            Rulings.Text = e.Message + "\nHTTP Error";
        }
    }
    
    private void ParseCardRulings()
    {
        var allRulings = "";
        if (File.Exists("cardrulings.json")) {
            var jsonString = File.ReadAllText("cardrulings.json");
            var obj = JsonNode.Parse(jsonString);
            
            for (var i = 0; i<obj?[2]?.AsArray().Count; i++) {
                var ruling = obj[2]?[i]?[4]?.ToString();
                allRulings += ruling + "\n\n";
            }
            Rulings.Text = allRulings;
        }
        else
        {
            Rulings.Text = "File 'cardrulings.json' not found";
        }

    }
    
    private PictureBox GetCardImage()
    {
        _image?.Dispose();
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.Accept, "image/jpg");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            var uri = "https://api.scryfall.com/cards/";
            uri += CardName.Text;
            uri += "/?format=image";
            try
            {
                client.DownloadFile(uri, "cards2.jpg");
            }
            catch (Exception e)
            {
                return new PictureBox();
            }
        }
        
        _image = Image.FromFile("cards2.jpg");
        var pictureBox = new PictureBox();
        pictureBox.Location = new Point(350, 100);
        pictureBox.Image = _image;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Size = new Size(250, 348);
        return pictureBox;
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        _cardImage?.Dispose();
        Rulings.Text = "";
        Scryfall_GetRuling();
        _cardImage = new PictureBox();
        _cardImage = GetCardImage();
        Controls.Add(_cardImage);
        ParseCardRulings();
    }
}