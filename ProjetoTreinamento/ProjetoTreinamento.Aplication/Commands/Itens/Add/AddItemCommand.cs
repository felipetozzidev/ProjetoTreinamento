using MediatR;
using ProjetoTreinamento.Domain.Enums;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Itens.Add;

public sealed class AddItemCommand : IRequest
{
    [JsonPropertyName("idChecklist")]
    public int IdChecklist { get; set; }

    [JsonPropertyName("idTarefa")]
    public int IdTarefa { get; set; }

    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }

    [JsonPropertyName("codigoStatus")]
    public CodigoStatusEnum CodigoStatus { get; set; }

    [JsonPropertyName("dataCriacao")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}
