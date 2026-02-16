using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select;

public class SelectChecklistCommand : IRequest
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}
