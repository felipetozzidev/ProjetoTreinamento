using Microsoft.EntityFrameworkCore;
using ProjetoTreinamento.Application.Queries.Checklists.GetAllChildren;
using ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;
using ProjetoTreinamento.Infrastructure.Contexts;
using System.Runtime.CompilerServices;

namespace ProjetoTreinamento.Infrastructure.Repositories;

public class ChecklistRepository : IChecklistRepository
{
    private readonly EXETPSContext _context;

    public ChecklistRepository(EXETPSContext context)
    {
        _context = context;
    }
    public async Task<Checklist> GetByIdAsync(int id)
    {
        var checklistGet = await _context.Checklist.FirstOrDefaultAsync(c =>  c.Id == id);
        return checklistGet == null ? throw new ChecklistNotFoundException() : checklistGet;
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

    public async Task UpdateAsync(Checklist checklist)
    {
        _context.Checklist.Update(checklist);
        await _context.SaveChangesAsync();
    }

    public async Task<Item[]> GetAllChecklistChildren(int id) =>
        await _context.Item.Where(c => c.IdChecklist == id).ToArrayAsync();

    public async Task<int> GetMaxId() =>
        await _context.Checklist.MaxAsync(x => (int?)x.Id) ?? 0;
}
