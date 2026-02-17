using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Commands.Tarefas.Delete
{
    public class DeleteTarefaCommand(int id) : IRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = id;
    }
}
