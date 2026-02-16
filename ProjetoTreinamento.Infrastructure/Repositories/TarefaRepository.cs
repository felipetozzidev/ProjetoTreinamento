using Microsoft.EntityFrameworkCore;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;
using ProjetoTreinamento.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTreinamento.Infrastructure.Repositories
{
    internal class TarefaRepository : ITarefaRepository
    {
        private readonly EXETPSContext _context;

        public TarefaRepository(EXETPSContext context)
        {
            _context = context;
        }
        public async Task<Tarefa> GetByID(int id)
        {
            var TarefaGet = await _context.Tarefa.FirstOrDefaultAsync(c => c.Id == id);
            return TarefaGet;
        }

        public async Task Add(Tarefa tarefa)
        {
            _context.Tarefa.Add(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Tarefa tarefa)
        {
            _context.Tarefa.Remove(tarefa);
            await _context.SaveChangesAsync();
        }


        public async Task Update(Tarefa tarefa)
        {
            _context.Tarefa.Update(tarefa);
            await _context.SaveChangesAsync();

        }
    }
}
