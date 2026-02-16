using MediatR;
using ProjetoTreinamento.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Checklists.Update
{
    public class UpdateChecklistCommand : IRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } = "Descrição padrão";

        [JsonPropertyName("codigoStatus")]
        public CodigoStatusEnum CodigoStatus { get; set; } = 0;

        [JsonPropertyName("dataCriacao")]
        public DateTime DataCriacao { get; private set; } = DateTime.Now;

        [JsonPropertyName("id")]
        public int IdTarefa { get; set; }
    }
}
