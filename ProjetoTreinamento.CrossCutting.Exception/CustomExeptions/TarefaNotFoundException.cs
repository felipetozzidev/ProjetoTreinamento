using ProjetoTreinamento.CrossCutting.Exceptions.Bases;
using System.Net;

namespace ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;

public sealed class TarefaNotFoundException(
    string message = "Tarefa não encontrada",
    HttpStatusCode httpStatusCode = HttpStatusCode.NotFound
) : ApiHttpCustomException(message, httpStatusCode) { }
