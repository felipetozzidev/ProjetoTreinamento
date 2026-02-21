using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;

namespace ProjetoTreinamento.Application.Queries.Checklists.GetAllChildren;

public class GetAllChecklistChildrenQueryHandler : IRequestHandler<GetAllChecklistChildrenQuery, GetAllChecklistChildrenQueryResponse[]>
{
    private readonly IChecklistService _checklistService;

    public GetAllChecklistChildrenQueryHandler(IChecklistService checklistService)
    {
        _checklistService = checklistService;
    }

    public async Task<GetAllChecklistChildrenQueryResponse[]> Handle(GetAllChecklistChildrenQuery request, CancellationToken cancellationToken) =>
        await _checklistService.MontaGetAllChecklistChildrenQueryResponse(request.Id);
}
