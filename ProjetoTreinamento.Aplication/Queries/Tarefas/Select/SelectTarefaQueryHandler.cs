using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;

namespace ProjetoTreinamento.Application.Queries.Tarefas.Select;

internal class SelectTarefaQueryHandler : IRequestHandler<SelectTarefaQuery, SelectTarefaQueryResponse>
{
    private readonly ITarefaService _tarefaService;

    public SelectTarefaQueryHandler(ITarefaService request)
    {
        _tarefaService = request;
    }

    public async Task<SelectTarefaQueryResponse> Handle(SelectTarefaQuery request, CancellationToken cancellationToken)=> 
        await _tarefaService.MontaSelectQueryResponse(request.Id);
}
