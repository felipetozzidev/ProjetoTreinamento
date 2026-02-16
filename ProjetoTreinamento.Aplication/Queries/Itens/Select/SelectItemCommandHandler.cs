using MediatR;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Queries.Checklists.Select;

internal class SelectItemCommandHandler : IRequestHandler<SelectItemCommand>
{
    private readonly IItemRepository _itemRepository;

    public SelectItemCommandHandler(IItemRepository request)
    {
        _itemRepository = request;
    }

    public async Task Handle(SelectItemCommand request, CancellationToken cancellationToken)
    {
        Item item = await _itemRepository.GetByID(request.Id);

    }
}
