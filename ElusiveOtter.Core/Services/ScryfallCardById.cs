using System.Text.Json.Nodes;

namespace ElusiveOtter.Core.Services;

public class ScryfallCardById : IScryfallCard
{
    public JsonNode FetchCard(bool isCommander, string cardId)
    {
        return new JsonObject();
    }
}