using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Tarefas.Select;

public class SelectTarefaCommand : IRequest
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}
