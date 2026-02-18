using MediatR;

namespace ProjetoTreinamento.Application.Queries.Tarefas.GetAll
{
    public class GetAllTarefaQuery : IRequest<GetAllTarefaQueryResponse[]> { }
}
