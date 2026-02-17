using ProjetoTreinamento.CrossCutting.Exceptions.Bases;
using System.Net;

namespace ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;

public sealed class ChecklistNotFoundException(
    string message = "Checklist não foi encontrada",
    HttpStatusCode httpStatusCode = HttpStatusCode.NotFound
) : ApiHttpCustomException(message, httpStatusCode) { }
