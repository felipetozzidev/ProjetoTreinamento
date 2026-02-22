using ProjetoTreinamento.Application.Commands.Checklists.Add;
using ProjetoTreinamento.Application.Queries.Checklists.GetAllChildren;
using ProjetoTreinamento.Application.Queries.Checklists.Select;

namespace ProjetoTreinamento.Application.Interfaces.Services;

public interface IChecklistService
{
    public Task<int> GetIdInclusao();
    public Task AddAsync(AddChecklistCommand addChecklistCommand);
    public Task<SelectChecklistQueryResponse> MontaSelectQueryResponse(int id);
    public Task<GetAllChecklistChildrenQueryResponse[]> MontaGetAllChecklistChildrenQueryResponse(int id);
}
