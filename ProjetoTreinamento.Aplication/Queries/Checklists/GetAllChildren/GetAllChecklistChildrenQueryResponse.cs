using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Checklists.GetAllChildren;

public class GetAllChecklistChildrenQueryResponse
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
}