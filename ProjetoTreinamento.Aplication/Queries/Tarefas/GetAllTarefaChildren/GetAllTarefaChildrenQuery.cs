using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Queries.Tarefas.GetAllTarefaChildren
{
    public class GetAllTarefaChildrenQuery(int id) : IRequest<GetAllTarefaChildrenQueryResponse[]> 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = id;
    }
}
