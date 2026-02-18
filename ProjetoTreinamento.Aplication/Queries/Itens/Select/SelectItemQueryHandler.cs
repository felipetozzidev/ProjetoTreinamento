using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Queries.Itens.Select;

internal class SelectItemQueryHandler : IRequestHandler<SelectItemQuery>
{
    private readonly IItemRepository _itemRepository;

    public SelectItemQueryHandler(IItemRepository request)
    {
        _itemRepository = request;
    }

    public async Task Handle(SelectItemQuery request, CancellationToken cancellationToken)
    {
        Item item = await _itemRepository.GetByIdAsync(request.Id);

    }
}
