using MediatR;
using Microsoft.IdentityModel.Tokens;
using ProjetoTreinamento.Application.Commands.Tarefas.Delete;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Application.Commands.Itens.Delete;

internal class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand>
{
    private readonly IItemRepository _itemRepository;
    public DeleteItemCommandHandler(IItemRepository repository)
    {
        _itemRepository = repository;
    }

    public async Task Handle(DeleteItemCommand request, CancellationToken cancellationToken)
    {
        Item item = await _itemRepository.GetByID(request.Id);
        await _itemRepository.Delete(item);
    }
}
