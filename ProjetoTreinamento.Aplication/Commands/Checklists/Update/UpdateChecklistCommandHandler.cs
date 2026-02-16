using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Checklists.Update;

internal class UpdateChecklistCommandHandler : IRequestHandler<UpdateChecklistCommand>
{
    private readonly IChecklistRepository _checklistRepository;

    public UpdateChecklistCommandHandler(IChecklistRepository checklistRepository)
    {
        _checklistRepository = checklistRepository;
    }

    public async Task Handle(UpdateChecklistCommand request, CancellationToken cancellationToken)
    {
        Checklist checklist = await _checklistRepository.GetByIdAsync(request.Id);
        checklist.AtualizarEntidadeChecklist(request.Titulo, request.Descricao, request.IdTarefa);
        await _checklistRepository.Update(checklist);
    }
}
