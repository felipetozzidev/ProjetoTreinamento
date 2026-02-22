using AutoMapper;
using Microsoft.Identity.Client;
using ProjetoTreinamento.Application.Commands.Checklists.Add;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Application.Queries.Checklists.GetAllChildren;
using ProjetoTreinamento.Application.Queries.Checklists.Select;
using ProjetoTreinamento.Application.Queries.Tarefas.GetAllTarefaChildren;
using ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Infrastructure.Services.Checklists;

public class ChecklistService : IChecklistService
{
    private readonly IChecklistRepository _checklistRepository;
    private readonly IMapper _mapper;
    public ChecklistService(
        IChecklistRepository checklistRepository,
        IMapper mapper
        )
    {
        _checklistRepository = checklistRepository;
        _mapper = mapper;
    }

    public async Task AddAsync(AddChecklistCommand addChecklistCommand)
    {
        Checklist entity = ConstroiChecklistEntity(addChecklistCommand);
        entity.SetId(await GetIdInclusao());
        await _checklistRepository.AddAsync(entity);
    }

    public async Task<int> GetIdInclusao() =>
        await _checklistRepository.GetMaxId() + 1;

    private static Checklist ConstroiChecklistEntity(AddChecklistCommand request) =>
        new Checklist(
            request.Titulo,
            request.Descricao,
            request.IdTarefa
        );

    public async Task<SelectChecklistQueryResponse> MontaSelectQueryResponse(int id)
    {
        Checklist checklist = await _checklistRepository.GetByIdAsync(id);
        if (checklist == null)
            throw new ChecklistNotFoundException();

        SelectChecklistQueryResponse mappedResponse = _mapper.Map<SelectChecklistQueryResponse>(checklist);
        mappedResponse.Status = checklist.GetStatus();
        return mappedResponse;
    }

    public async Task<GetAllChecklistChildrenQueryResponse[]> MontaGetAllChecklistChildrenQueryResponse(int id)
    {
        Item[] itemInChecklist = await _checklistRepository.GetAllChecklistChildren(id);
        List<GetAllChecklistChildrenQueryResponse> response = new List<GetAllChecklistChildrenQueryResponse>();

        if (itemInChecklist == null || !itemInChecklist.Any())
            throw new ItemDoesntExists();

        foreach (Item item in itemInChecklist)
        {
            GetAllChecklistChildrenQueryResponse mappedResponse = _mapper.Map<GetAllChecklistChildrenQueryResponse>(item);
            mappedResponse.Status = item.GetStatus();
            response.Add(mappedResponse);
        }

        return response.ToArray();
    }
}
