using System.Text.Json.Nodes;

namespace ElusiveOtter.Core.Services;

public interface IScryfallCard
{
    public JsonNode FetchCard(bool isCommander, string cardId);
}