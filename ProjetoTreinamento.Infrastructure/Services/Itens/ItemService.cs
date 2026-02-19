using ProjetoTreinamento.Application.Commands.Itens.Add;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Infrastructure.Services.Itens;

public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;

    public ItemService(
        IItemRepository itemRepository
    )
    {
        _itemRepository = itemRepository;
    }

    public async Task AddAsync(AddItemCommand addItemCommand)
    {
        Item entity = ConstroiItemEntity(addItemCommand);
        entity.SetId(await GetIdInclusao());
        await _itemRepository.AddAsync(entity);
    }

    public async Task<int> GetIdInclusao() =>
        await _itemRepository.GetMaxId() + 1;

    public static Item ConstroiItemEntity(AddItemCommand request) =>
        new Item(
            request.Titulo,
            request.IdTarefa,
            request.IdChecklist
        );

}
