using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Tarefas.Select;

public class SelectTarefaQuery(int id) : IRequest<SelectTarefaQueryResponse>
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = id;
}
