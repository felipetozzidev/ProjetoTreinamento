using ProjetoTreinamento.CrossCutting.Exceptions.Bases;
using System.Net;

namespace ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;

public class ItemDoesntExists(
    string message = "Não há nenhum item vinculado a este checklist",
    HttpStatusCode httpStatusCode = HttpStatusCode.NotFound
) : ApiHttpCustomException(message, httpStatusCode) { }
