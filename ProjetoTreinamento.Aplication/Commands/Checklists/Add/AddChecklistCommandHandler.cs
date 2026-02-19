using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Checklists.Add;

internal class AddChecklistCommandHandler : IRequestHandler<AddChecklistCommand>
{
    private readonly Interfaces.Services.IChecklistService _checklistService;

    public AddChecklistCommandHandler(Interfaces.Services.IChecklistService checklistService)
    {
        _checklistService = checklistService;
    }

    public async Task Handle(AddChecklistCommand request, CancellationToken cancellationToken)
    {
        await _checklistService.AddAsync(request);
        
    }

}
