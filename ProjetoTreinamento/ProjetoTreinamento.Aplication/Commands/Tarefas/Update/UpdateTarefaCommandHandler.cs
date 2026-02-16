using MediatR;
using ProjetoTreinamento.Application.Commands.Itens.Update;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Tarefas.Update;

internal class UpdateTarefaCommandHandler : IRequestHandler<UpdateTarefaCommand>
{
    private readonly ITarefaRepository _tarefaRepository;

    public UpdateTarefaCommandHandler(ITarefaRepository tarefaRepository) {
        _tarefaRepository = tarefaRepository;
    }

    public async Task Handle(UpdateTarefaCommand request, CancellationToken cancellationToken)
    {
        Tarefa tarefa = await _tarefaRepository.GetByID(request.Id);
        tarefa.AtualizarEntidadeTarefa(request.Titulo, request.Descricao, request.Prazo);
        await _tarefaRepository.Update(tarefa);
    }

}