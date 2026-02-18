using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select;

internal class SelectChecklistQueryHandler : IRequestHandler<SelectChecklistQuery>
{
    private readonly IChecklistRepository _checklistRepository;

    public SelectChecklistQueryHandler(IChecklistRepository request)
    {
        _checklistRepository = request;
    }

    public async Task Handle(SelectChecklistQuery request, CancellationToken cancellationToken)
    {
        Checklist checklist = await _checklistRepository.GetByIdAsync(request.Id);

    }
}
