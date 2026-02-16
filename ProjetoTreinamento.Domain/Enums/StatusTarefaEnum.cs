using System.ComponentModel;

namespace ProjetoTreinamento.Domain.Enums
{
    public enum StatusTarefaEnum
    {
        [Description("Pendente")] 
        Pendente = 1,

        [Description("Realizado")]
        Realizado = 2,

        [Description("Atrasado")]
        Atrasado = 3
    }
}
