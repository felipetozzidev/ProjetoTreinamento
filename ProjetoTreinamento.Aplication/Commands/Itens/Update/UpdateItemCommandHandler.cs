using MediatR;
using ProjetoTreinamento.Application.Commands.Tarefas.Update;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Itens.Update;

internal class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand>
{
    private readonly IItemRepository _itemRepository;

    public UpdateItemCommandHandler(IItemRepository itemRepository) {
        _itemRepository = itemRepository;
    }

    public async Task Handle(UpdateItemCommand request, CancellationToken cancellationToken)
    {
        Item item = await _itemRepository.GetByIdAsync(request.Id);
        item.AtualizarEntidadeItem(request.Titulo, request.IdTarefa, request.IdChecklist);
        await _itemRepository.UpdateAsync(item);
    }

}
