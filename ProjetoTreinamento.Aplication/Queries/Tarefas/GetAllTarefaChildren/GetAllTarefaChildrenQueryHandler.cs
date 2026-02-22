using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;

namespace ProjetoTreinamento.Application.Queries.Tarefas.GetAllTarefaChildren;

public class GetAllTarefaChildrenQueryHandler : IRequestHandler<GetAllTarefaChildrenQuery, GetAllTarefaChildrenQueryResponse[]>
{
    private readonly ITarefaService _tarefaService;
    public GetAllTarefaChildrenQueryHandler(ITarefaService tarefaService)
    {
        _tarefaService = tarefaService;
    }

    public async Task<GetAllTarefaChildrenQueryResponse[]> Handle(GetAllTarefaChildrenQuery request, CancellationToken cancellationToken) =>
        await _tarefaService.MontaGetAllTarefaChildrenQueryResponse(request.Id);
}
