using System.Net;

namespace Deck_Randomiser_3;

public partial class RandomCard : UserControl
{
    
    private PictureBox cardImage;
    private Image image;
    
    public RandomCard()
    {
        InitializeComponent();
    }

    private void GetCard_Click(object sender, EventArgs e)
    {
        cardImage?.Dispose();
        this.Controls.Remove(cardImage);
        cardImage = new PictureBox();
        cardImage = Scryfall_Get(false);
        this.Controls.Add(cardImage);
    }
    
    private PictureBox Scryfall_Get(bool isCommander)
    {
        image?.Dispose();
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.Accept, "image/jpg");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            string uri = "https://api.scryfall.com/cards/random/?";
            if (isCommander || SearchCriteria.Text != "")
            {
                uri += "q=";
            }
            if (isCommander) {
                uri += "is%3Acommander";
            }
            
            foreach (string line in SearchCriteria.Text.Split("\n"))
            {
                string encodeLine = HtmlEncode(line);
                if (line != SearchCriteria.Text.Split("\n")[0] || isCommander)
                {
                    encodeLine = "+" + encodeLine; 
                }
                uri += encodeLine;
            }
            uri += "&format=image";
            try
            {
                client.DownloadFile(uri, "cards.jpg");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        image = Image.FromFile("cards.jpg");
        var pictureBox = new PictureBox();
        pictureBox.Location = new Point(40, 30);
        pictureBox.Image = image;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Size = new Size(292, 408);
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

    private void GetCommander_Click(object sender, EventArgs e)
    {
        cardImage?.Dispose();
        this.Controls.Remove(cardImage);
        cardImage = new PictureBox();
        cardImage = Scryfall_Get(true);
        this.Controls.Add(cardImage);
    }
}