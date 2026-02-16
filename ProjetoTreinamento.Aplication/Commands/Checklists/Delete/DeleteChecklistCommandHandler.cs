using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Checklists.Delete;

public class DeleteChecklistCommandHandler : IRequestHandler<DeleteChecklistCommand>
{
    private readonly IChecklistRepository _checklistRepository;
    public DeleteChecklistCommandHandler(IChecklistRepository repository)
    {
        _checklistRepository = repository;
    }

    public async Task Handle(DeleteChecklistCommand request, CancellationToken cancellationToken)
    {
        Checklist checklist = await _checklistRepository.GetByID(request.Id);
        await _checklistRepository.Delete(checklist);
    }
}
