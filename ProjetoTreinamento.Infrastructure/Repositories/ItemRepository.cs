using Microsoft.EntityFrameworkCore;
using ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;
using ProjetoTreinamento.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTreinamento.Infrastructure.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly EXETPSContext _context;

    public ItemRepository(EXETPSContext context)
    {
        _context = context;
    }
    public async Task<Item> GetByIdAsync(int id)
    {
        var itemGet = await _context.Item.FirstOrDefaultAsync(c => c.Id == id);
        return itemGet == null ? throw new ItemDoesntExists() : itemGet;
    }

    public async Task AddAsync(Item item)
    {
        _context.Item.Add(item);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Item item)
    {
        _context.Item.Remove(item);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Item item)
    {
        _context.Item.Update(item);
        await _context.SaveChangesAsync();

    }

    public async Task<int> GetMaxId() =>
        await _context.Item.MaxAsync(x => (int?)x.Id) ?? 0;
}
