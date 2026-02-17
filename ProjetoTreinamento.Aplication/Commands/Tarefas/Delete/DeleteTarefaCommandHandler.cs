using MediatR;
using Microsoft.IdentityModel.Tokens;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Tarefas.Delete;

internal class DeleteTarefaCommandHandler : IRequestHandler<DeleteTarefaCommand>
{
    private readonly ITarefaRepository _tarefaRepository;
    public DeleteTarefaCommandHandler(ITarefaRepository repository)
    {
        _tarefaRepository = repository;
    }

    public async Task Handle(DeleteTarefaCommand request, CancellationToken cancellationToken)
    {
        Tarefa tarefa = await _tarefaRepository.GetByIdAsync(request.Id);
        await _tarefaRepository.DeleteAsync(tarefa);
    }
}
