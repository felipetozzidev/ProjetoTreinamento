using MediatR;
using ProjetoTreinamento.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Tarefas.Update
{
    public class UpdateTarefaCommand : IRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } = string.Empty;

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("prazo")]
        public DateTime Prazo { get; set; }

        [JsonPropertyName("codigoStatus")]
        public StatusTarefaEnum CodigoStatus { get; set; }

        [JsonPropertyName("dataCriacao")]
        public DateTime DataCricao { get; set; } = DateTime.Now;
    }
}
