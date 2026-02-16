using MediatR;
using ProjetoTreinamento.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Itens.Update
{
    public class UpdateItemCommand : IRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("idTarefa")]
        public int IdTarefa { get; set; }

        [JsonPropertyName("idChecklist")]
        public int IdChecklist { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("dataCriacao")]
        public DateTime DataCricao { get; set; } = DateTime.Now;
    }
}
