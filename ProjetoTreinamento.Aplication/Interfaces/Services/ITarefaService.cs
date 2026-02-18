using ProjetoTreinamento.Application.Commands.Tarefas.Add;
using ProjetoTreinamento.Application.Queries.Tarefas.GetAll;
using ProjetoTreinamento.Application.Queries.Tarefas.Select;

namespace ProjetoTreinamento.Application.Interfaces.Services;
public interface ITarefaService
{
    public Task<GetAllTarefaQueryResponse[]> MontaGetAllTarefaQueryResponse();
    public Task<SelectTarefaQueryResponse> MontaSelectQueryResponse(int id);
    public Task<int> GetIdInclusao();
    public Task AddAsync(AddTarefaCommand addTarefaCommand);
}
