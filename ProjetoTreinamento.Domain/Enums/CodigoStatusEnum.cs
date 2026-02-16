using System.ComponentModel;

namespace ProjetoTreinamento.Domain.Enums
{
    public enum CodigoStatusEnum
    {
        [Description("Pendente")]
        Pendente = 1,

        [Description("Realizado agora")]
        Realizado = 2,
    }
}
