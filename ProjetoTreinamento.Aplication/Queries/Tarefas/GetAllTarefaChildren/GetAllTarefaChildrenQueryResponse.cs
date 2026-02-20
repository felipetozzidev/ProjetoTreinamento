using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Tarefas.GetAllTarefaChildren
{
    public class GetAllTarefaChildrenQueryResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; } = string.Empty;
        
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; } = string.Empty;
        
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }
}