using Microsoft.EntityFrameworkCore;
using ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;
using ProjetoTreinamento.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTreinamento.Infrastructure.Repositories;

public class TarefaRepository : ITarefaRepository
{
    private readonly EXETPSContext _context;

    public TarefaRepository(EXETPSContext context)
    {
        _context = context;
    }

    public async Task<Tarefa?> GetByIdAsync(int id) => 
        await _context.Tarefa.FirstOrDefaultAsync(c => c.Id == id);
    

    public async Task AddAsync(Tarefa tarefa)
    {
        _context.Tarefa.Add(tarefa);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Tarefa tarefa)
    {
        _context.Tarefa.Remove(tarefa);
        await _context.SaveChangesAsync();
    }


    public async Task UpdateAsync(Tarefa tarefa)
    {
        _context.Tarefa.Update(tarefa);
        await _context.SaveChangesAsync();
    }

    public async Task<Tarefa[]> GetAllAsync() => 
        await _context.Tarefa.ToArrayAsync();

    public async Task<int> GetMaxId() => 
        await _context.Tarefa.MaxAsync(x => (int?)x.Id) ?? 0;

    public async Task<Checklist[]> GetAllChildrenAsync(int id) =>
       await _context.Checklist.Where(c => c.IdTarefa == id).ToArrayAsync();
}
