using ProjetoTreinamento.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTreinamento.Domain.Entities;


public class Item
{
    [Key]
    public int Id { get; private set; }

    [Key]
    public int IdChecklist { get; private set; }

    [Key]
    public int IdTarefa { get; private set; }

    //Titulo aqui equivale à Descrição do item
    public string? Titulo { get; private set; }

    public CodigoStatusEnum CodigoStatus { get; private set; } = CodigoStatusEnum.Pendente;

    public DateTime DataCriacao { get; private set; } = DateTime.Now;

    public Item(
       string? titulo,
       int idTarefa,
       int idChecklist
   )
    {
        Titulo = titulo;
        IdTarefa = idTarefa;
        IdChecklist = idChecklist;

    }

    public void SetId(int id) =>
        Id = id;

    public void AtualizarEntidadeItem(
        string titulo,  
        int idTarefa,
        int idChecklist
    )
    {
        this.Titulo = titulo;
        this.IdTarefa = idTarefa;
        this.IdChecklist = idChecklist;
    }
}
