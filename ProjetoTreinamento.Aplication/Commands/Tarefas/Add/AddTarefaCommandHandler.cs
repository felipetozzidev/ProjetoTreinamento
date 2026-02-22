using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Tarefas.Add;

public sealed class AddTarefaCommandHandler : IRequestHandler<AddTarefaCommand>
{
    private readonly ITarefaService _tarefaService;
    public AddTarefaCommandHandler(
        ITarefaService tarefaService
    )
    {
        _tarefaService = tarefaService;
    }

    public async Task Handle(AddTarefaCommand request, CancellationToken cancellationToken) =>  await _tarefaService.AddAsync(request);
    

    
}
