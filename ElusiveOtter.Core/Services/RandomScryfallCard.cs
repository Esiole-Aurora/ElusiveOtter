using System.Net;
using System.Text.Json.Nodes;

namespace ElusiveOtter.Core.Services;

public class RandomScryfallCard : IScryfallCard
{
    public JsonNode FetchCard(bool isCommander, string card = "")
    {
        using var client = new WebClient();
        client.Headers.Add(HttpRequestHeader.Accept, "*/*");
        client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");

        var query = BuildQuery(card, isCommander);
        var uri = "https://api.scryfall.com/cards/random";
        if (query != "")
        {
            uri += "?q=" + query;
        }

        var jsonString = client.DownloadString(uri);
        return JsonNode.Parse(jsonString);
    }
    private string BuildQuery(string searchCriteria, bool isCommander)
    {
        var query = "";

        if (isCommander)
        {
            query += "is%3Acommander";
        }

        if (searchCriteria != "")
        {
            var lines = searchCriteria.Split("\n");
            foreach (var line in lines)
            {
                if (line == "") continue;
                var encodedLine = HtmlEncode(line);
                query += (query != "" ? "+" : "") + encodedLine;
            }
        }

        return query;
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

    public void FetchImage(JsonNode card)
    {
        var imageUrl = card?["image_uris"]?["normal"]?.ToString()
                       ?? card?["card_faces"]?[0]?["image_uris"]?["normal"]?.ToString();
        
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            client.DownloadFile(imageUrl, "cards.jpg");
        }
    }
}