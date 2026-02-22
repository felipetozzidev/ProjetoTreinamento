using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select;

internal class SelectChecklistQueryHandler : IRequestHandler<SelectChecklistQuery, SelectChecklistQueryResponse>
{
    private readonly IChecklistService _checklistService;

    public SelectChecklistQueryHandler(IChecklistService request)
    {
        _checklistService = request;
    }

    public async Task<SelectChecklistQueryResponse> Handle(SelectChecklistQuery request, CancellationToken cancellationToken) =>
        await _checklistService.MontaSelectQueryResponse(request.Id);
}
