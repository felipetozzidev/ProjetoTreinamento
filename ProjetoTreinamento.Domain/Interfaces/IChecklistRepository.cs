using ProjetoTreinamento.Domain.Entities;

namespace ProjetoTreinamento.Domain.Interfaces
{
    public interface IChecklistRepository
    {
        Task<Checklist> GetByIdAsync(int id);
        Task AddAsync(Checklist checklist);
        Task UpdateAsync(Checklist checklist);
        Task DeleteAsync(Checklist checklist);
        Task<int> GetMaxId();
        Task<Item[]> GetAllChecklistChildren(int id);
    }
}
