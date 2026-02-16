using MediatR;
using ProjetoTreinamento.Domain.Enums;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Checklists.Add;

public sealed class AddChecklistCommand : IRequest
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; } = string.Empty;

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; } = "Descrição padrão";

    [JsonPropertyName("codigoStatus")]
    public CodigoStatusEnum CodigoStatus { get; set; } = CodigoStatusEnum.Pendente;

    [JsonPropertyName("dataCriacao")]
    public DateTime DataCriacao { get; private set; } = DateTime.Now;

    [JsonPropertyName("idTarefa")]
    public int IdTarefa { get; set; }
}
