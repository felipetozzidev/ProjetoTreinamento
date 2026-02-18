using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;

namespace ProjetoTreinamento.Application.Queries.Tarefas.GetAll;

public class GetAllTarefaQueryHandler : IRequestHandler<GetAllTarefaQuery, GetAllTarefaQueryResponse[]>
{
    private readonly ITarefaService _tarefaService;

    public GetAllTarefaQueryHandler(ITarefaService tarefaService)
    {
        _tarefaService = tarefaService;
    }

    public async Task<GetAllTarefaQueryResponse[]> Handle(GetAllTarefaQuery request, CancellationToken cancellationToken) => 
        await _tarefaService.MontaGetAllTarefaQueryResponse();

}
