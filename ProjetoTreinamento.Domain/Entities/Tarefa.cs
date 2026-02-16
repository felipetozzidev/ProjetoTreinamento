using ProjetoTreinamento.CrossCutting.Exceptions;
using ProjetoTreinamento.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTreinamento.Domain.Entities;

public class Tarefa
{
    [Key]
    public int Id { get; private set; }
    public string Titulo { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = "Descricao Tarefa";
    public DateTime? Prazo { get; private set; }
    public StatusTarefaEnum CodigoStatus { get; private set; }
    public DateTime DataCriacao { get; private set; } = DateTime.Now;
    public DateTime? ConcluidaEm { get; private set; }

    public Tarefa(
        string titulo,
        string descricao,
        DateTime? prazo
    )
    {
        Titulo = titulo;
        Descricao = descricao;
        Prazo = prazo;
    }

    public void ValidaPrazo()
    {
        if (Prazo < DateTime.Today)
            throw new TarefaNotFoundException();
    }

    public void ValidaDescricao()
    {

    }

    public void AtualizarEntidadeTarefa(string titulo, string descricao, DateTime prazo)
    {
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Prazo = prazo;
    }
}
