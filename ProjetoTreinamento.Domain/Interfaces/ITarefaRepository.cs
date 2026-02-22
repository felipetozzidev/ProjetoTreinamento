using ProjetoTreinamento.Domain.Entities;

namespace ProjetoTreinamento.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        Task<Tarefa?> GetByIdAsync(int id);
        Task AddAsync(Tarefa tarefa);
        Task UpdateAsync(Tarefa tarefa);
        Task DeleteAsync(Tarefa tarefa);
        Task<Tarefa[]> GetAllAsync();
        Task<int> GetMaxId();
        Task<Checklist[]> GetAllChildrenAsync(int id);
    }
}
