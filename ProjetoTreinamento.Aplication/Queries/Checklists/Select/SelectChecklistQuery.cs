using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select;

public class SelectChecklistQuery(int id) : IRequest<SelectChecklistQueryResponse>
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = id;
}
