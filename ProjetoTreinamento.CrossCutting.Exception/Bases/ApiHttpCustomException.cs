using System.Net;

namespace ProjetoTreinamento.CrossCutting.Exceptions.Bases;

public class ApiHttpCustomException(string message, HttpStatusCode responseCode) : Exception(message)
{
    public HttpStatusCode ResponseCode { get; } = responseCode;
}
