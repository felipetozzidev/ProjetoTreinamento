using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select;

internal class SelectChecklistCommandHandler : IRequestHandler<SelectChecklistCommand>
{
    private readonly IChecklistRepository _checklistRepository;

    public SelectChecklistCommandHandler(IChecklistRepository request)
    {
        _checklistRepository = request;
    }

    public async Task Handle(SelectChecklistCommand request, CancellationToken cancellationToken)
    {
        Checklist checklist = await _checklistRepository.GetByID(request.Id);

    }
}
