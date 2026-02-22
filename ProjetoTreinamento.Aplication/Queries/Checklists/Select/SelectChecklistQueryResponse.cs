using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select
{
    public class SelectChecklistQueryResponse
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } = string.Empty;

        [JsonPropertyName("idTarefa")]
        public int IdTarefa { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }
}
