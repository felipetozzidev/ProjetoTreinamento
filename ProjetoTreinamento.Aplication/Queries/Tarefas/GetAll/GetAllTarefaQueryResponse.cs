using ProjetoTreinamento.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Tarefas.GetAll
{
    public class GetAllTarefaQueryResponse
    {

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } = string.Empty;

        [JsonPropertyName("prazo")]
        public DateTime Prazo { get; set; }

        [JsonPropertyName("swtatus")]
        public string Status { get; set; }= string.Empty;
    }
}
