using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Itens.Select;

public class SelectItemQuery(int id) : IRequest
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = id;
}
