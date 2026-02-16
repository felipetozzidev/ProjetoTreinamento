using Microsoft.EntityFrameworkCore;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;
using ProjetoTreinamento.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTreinamento.Infrastructure.Repositories
{
    internal class ItemRepository : IItemRepository
    {
        private readonly EXETPSContext _context;

        public ItemRepository(EXETPSContext context)
        {
            _context = context;
        }
        public async Task<Item> GetByID(int id)
        {
            var ItemGet = await _context.Item.FirstOrDefaultAsync(c => c.Id == id);
            return ItemGet;
        }

        public async Task Add(Item item)
        {
            _context.Item.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Item item)
        {
            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Item item)
        {
            _context.Item.Update(item);
            await _context.SaveChangesAsync();

        }


    }
}
