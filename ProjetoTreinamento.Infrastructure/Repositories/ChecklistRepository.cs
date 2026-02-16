using Microsoft.EntityFrameworkCore;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;
using ProjetoTreinamento.Infrastructure.Contexts;

namespace ProjetoTreinamento.Infrastructure.Repositories
{
    internal class ChecklistRepository : IChecklistRepository
    {
        private readonly EXETPSContext _context;

        public ChecklistRepository(EXETPSContext context)
        {
            _context = context;
        }
        public async Task<Checklist> GetByIdAsync(int id)
        {
            var checklistGet = await _context.Checklist.FirstOrDefaultAsync(c =>  c.Id == id);
            return checklistGet == null ? throw new ;
        }

        public async Task AddAsync(Checklist checklist)
        {
            _context.Checklist.Add(checklist);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Checklist checklist)
        {
            _context.Checklist.Remove(checklist);
            await _context.SaveChangesAsync();
        }


        public async Task Update(Checklist checklist)
        {
            _context.Checklist.Update(checklist);
            await _context.SaveChangesAsync();
            
        }
    }
}
