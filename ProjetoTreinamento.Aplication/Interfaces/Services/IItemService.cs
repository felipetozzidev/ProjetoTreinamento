using ProjetoTreinamento.Application.Commands.Itens.Add;

namespace ProjetoTreinamento.Application.Interfaces.Services;

public interface IItemService
{
    public Task<int> GetIdInclusao();
    public Task AddAsync(AddItemCommand addItemCommand);
}
