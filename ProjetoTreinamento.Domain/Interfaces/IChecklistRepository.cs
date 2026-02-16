using ProjetoTreinamento.Domain.Entities;

namespace ProjetoTreinamento.Domain.Interfaces
{
    public interface IChecklistRepository
    {
        public Task<Checklist> GetByIdAsync(int id);
        public Task AddAsync(Checklist checklist);
        public Task UpdateAsync(Checklist checklist);
        public Task DeleteAsync(Checklist checklist);
    }
}
