namespace ProjetoTreinamento.Application.Models.DTOs.Bases;

public class ServiceResult
{
    public ServiceResult(bool sucesso = true, string? mensagem = null)
    {
        Sucesso = sucesso;
        Mensagem = mensagem ?? string.Empty;
    }

    public bool Sucesso { get; set; }
    public string Mensagem { get; set; }

    public ServiceResult<T> ToServiceResult<T>(T? resultado = default)
    {
        return new ServiceResult<T>(resultado, Sucesso, Mensagem);
    }
}

public class ServiceResult<R> : ServiceResult
{
    public ServiceResult(R? resultado, bool sucesso = true, string? mensagem = null)
    {
        Sucesso = sucesso;
        Mensagem = mensagem ?? string.Empty;
        Resultado = resultado;
    }

    public R? Resultado { get; set; }
}
