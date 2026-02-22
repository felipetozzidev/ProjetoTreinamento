using ProjetoTreinamento.Domain.Entities;

namespace ProjetoTreinamento.Domain.Interfaces
{
    public interface IItemRepository
    {
        public Task<Item> GetByIdAsync(int id);
        public Task AddAsync(Item item);
        public Task UpdateAsync(Item item);
        public Task DeleteAsync(Item item);
        public Task<int> GetMaxId();
    }
}
