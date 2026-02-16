using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Checklists.Delete;

public class DeleteChecklistCommand : IRequest
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}
