using ProjetoTreinamento.Domain.Entities;

namespace ProjetoTreinamento.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        public Task<Tarefa> GetByIdAsync(int id);
        public Task AddAsync(Tarefa tarefa);
        public Task UpdateAsync(Tarefa tarefa);
        public Task DeleteAsync(Tarefa tarefa);
    }
}
