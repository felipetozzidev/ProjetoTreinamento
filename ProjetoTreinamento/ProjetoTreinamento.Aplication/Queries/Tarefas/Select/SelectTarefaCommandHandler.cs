using MediatR;
using ProjetoTreinamento.Application.Queries.Checklists.Select;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Queries.Tarefas.Select;

internal class SelectTarefaCommandHandler : IRequestHandler<SelectTarefaCommand>
{
    private readonly IChecklistRepository _tarefaRepository;

    public SelectTarefaCommandHandler(IChecklistRepository request)
    {
        _tarefaRepository = request;
    }

    public async Task Handle(SelectTarefaCommand request, CancellationToken cancellationToken)
    {
        Checklist checklist = await _tarefaRepository.GetByID(request.Id);

    }
}
