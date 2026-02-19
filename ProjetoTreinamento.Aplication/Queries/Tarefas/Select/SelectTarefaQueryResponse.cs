using ProjetoTreinamento.Application.Queries.Tarefas.GetAll;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Tarefas.Select;

public class SelectTarefaQueryResponse : GetAllTarefaQueryResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}
