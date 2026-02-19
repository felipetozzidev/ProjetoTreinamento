using MediatR;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Itens.Add;

internal class AddItemCommandHandler : IRequestHandler<AddItemCommand>
{

    private readonly IItemService _itemService;

    public AddItemCommandHandler(
            IItemService itemService
    )
    {
        _itemService = itemService;
    }

    public async Task Handle(AddItemCommand request, CancellationToken cancellationToken) =>
        await _itemService.AddAsync(request);

}
