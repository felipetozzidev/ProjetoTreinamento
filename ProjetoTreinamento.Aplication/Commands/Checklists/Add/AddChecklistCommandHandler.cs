using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Checklists.Add;

internal class AddChecklistCommandHandler : IRequestHandler<AddChecklistCommand>
{
    private readonly IChecklistRepository _checklistRepository;

    public AddChecklistCommandHandler(IChecklistRepository checklistRepository)
    {
        _checklistRepository = checklistRepository;
    }

    public async Task Handle(AddChecklistCommand request, CancellationToken cancellationToken)
    {
        var checklistEtntity = ConstroiChecklistentity(request);
        await _checklistRepository.AddAsync(checklistEtntity);
    }

    public static Checklist ConstroiChecklistentity(AddChecklistCommand request) =>
        new Checklist(
            request.Titulo,
            request.Descricao,
            request.IdTarefa
        );
}
