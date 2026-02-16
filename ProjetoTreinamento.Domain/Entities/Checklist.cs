using ProjetoTreinamento.Domain.Enums;
using ProjetoTreinamento.Domain.Shareds.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTreinamento.Domain.Entities;

[Table("Checklist")]
public class Checklist
{
    [Key]
    public int Id { get; private set; }
    public string Titulo { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = "Descrição padrão";
    public CodigoStatusEnum CodigoStatus { get; private set; } = 0;
    public DateTime DataCriacao { get; private set; } = DateTime.Now;
    public int IdTarefa { get; private set; }
    

    public Checklist(
        string titulo,
        string descricao,
        int idTarefa
    )
    {
        Titulo = titulo;
        Descricao = descricao;
        IdTarefa = idTarefa;
    }

    public void AtualizarEntidadeChecklist(
        string titulo,
        string descricao,
        int idTarefa
    )
    {
        this.Titulo = titulo;
        this.Descricao = descricao; 
        this.IdTarefa = idTarefa;
        
    }
}
