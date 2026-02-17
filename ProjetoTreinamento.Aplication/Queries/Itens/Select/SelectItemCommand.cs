using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select;

public class SelectItemCommand(int id) : IRequest
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = id;
}
