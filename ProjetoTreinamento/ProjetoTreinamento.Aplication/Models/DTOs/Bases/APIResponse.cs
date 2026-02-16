using System.Text.Json.Serialization;

namespace ProjetoTreinamento.Application.Models.DTOs.Bases;

public class APIResponse
{
    public APIResponse(bool sucesso, string? mensagem = null)
    {
        Sucesso = sucesso;
        Mensagem = mensagem;
    }

    public bool Sucesso { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Mensagem { get; set; }


    public static implicit operator APIResponse(ServiceResult serviceResult)
    {
        return new(serviceResult.Sucesso, serviceResult.Mensagem);
    }
}

public class APIResponse<R> : APIResponse
{
    public APIResponse(R? retorno, bool sucesso = true, string? mensagem = null) : base(sucesso, mensagem)
    {
        Retorno = retorno;
    }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public R? Retorno { get; set; }

    public static implicit operator APIResponse<R>(ServiceResult<R> serviceResult)
    {
        return new(serviceResult.Resultado, serviceResult.Sucesso, serviceResult.Mensagem);
    }
}
