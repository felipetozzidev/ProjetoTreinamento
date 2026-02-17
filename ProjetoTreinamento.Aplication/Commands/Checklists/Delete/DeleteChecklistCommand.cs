using MediatR;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Checklists.Delete;

public class DeleteChecklistCommand(int id) : IRequest
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = id;
}
