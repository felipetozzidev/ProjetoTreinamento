using MediatR;
using ProjetoTreinamento.Application.Commands.Checklists.Add;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Itens.Add;

internal class AddItemCommandHandler : IRequestHandler<AddItemCommand>
{

    private readonly IItemRepository _itemRepository;

    public AddItemCommandHandler(
            IItemRepository itemRepository
    )
    {
        _itemRepository = itemRepository;
    }

    public async Task Handle(AddItemCommand request, CancellationToken cancellationToken)
    {
        var itemEtntity = ConstroiItemEntity(request);
        await _itemRepository.Add(itemEtntity);
    }

    public static Item ConstroiItemEntity(AddItemCommand request) =>
        new Item(
            request.Titulo,
            request.IdTarefa,
            request.IdChecklist
        );
}
