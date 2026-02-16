using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Tarefas.Add;

public sealed class AddTarefaCommandHandler : IRequestHandler<AddTarefaCommand>
{
    private readonly ITarefaRepository _tarefaRepository;
    public AddTarefaCommandHandler(
        ITarefaRepository tarefaRepository
    )
    {
        _tarefaRepository = tarefaRepository;
    }

    public async Task Handle(AddTarefaCommand request, CancellationToken cancellationToken)
    {
        var tarefaEntity = ConstroiTarefaEntity(request);

        await _tarefaRepository.Add(tarefaEntity);
    }

    private static Tarefa ConstroiTarefaEntity(AddTarefaCommand request) =>
         new Tarefa(
            request.Titulo,
            request.Descricao,
            request.Prazo
            );
    
}
