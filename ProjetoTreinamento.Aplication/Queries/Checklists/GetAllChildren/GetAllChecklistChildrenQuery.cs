using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Checklists.GetAllChildren;

public class GetAllChecklistChildrenQuery(int id) : IRequest<GetAllChecklistChildrenQueryResponse[]>
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = id;
}

