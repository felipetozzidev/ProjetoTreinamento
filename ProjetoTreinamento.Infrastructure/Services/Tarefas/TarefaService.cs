using AutoMapper;
using Azure.Core;
using ProjetoTreinamento.Application.Commands.Tarefas.Add;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Application.Queries.Tarefas.GetAll;
using ProjetoTreinamento.Application.Queries.Tarefas.Select;
using ProjetoTreinamento.CrossCutting.Exceptions.CustomExeptions;
using ProjetoTreinamento.Domain.Entities;
using ProjetoTreinamento.Domain.Interfaces;

namespace ProjetoTreinamento.Infrastructure.Services.Tarefas;

public class TarefaService : ITarefaService
{
    private readonly IMapper _mapper;
    private readonly ITarefaRepository _tarefaRepository;
    public TarefaService(
        IMapper mapper,
        ITarefaRepository tarefaRepository
    )
    {
        _mapper = mapper;
        _tarefaRepository = tarefaRepository;
    }

    public async Task<GetAllTarefaQueryResponse[]> MontaGetAllTarefaQueryResponse()
    {
        Tarefa[] tarefas = await _tarefaRepository.GetAllAsync();
        List<GetAllTarefaQueryResponse> response = new List<GetAllTarefaQueryResponse>();

        foreach (Tarefa tarefa in tarefas)
        {
            GetAllTarefaQueryResponse mappedResponse = _mapper.Map<GetAllTarefaQueryResponse>(tarefa);

            mappedResponse.Status = tarefa.GetSituacao();

            response.Add(mappedResponse);
        }

        return response.ToArray();
    }

    public async Task<SelectTarefaQueryResponse> MontaSelectQueryResponse(int id)
    {
        Tarefa? tarefa = await _tarefaRepository.GetByIdAsync(id);
        if (tarefa == null)
            throw new TarefaNotFoundException();

        SelectTarefaQueryResponse mappedResponse = _mapper.Map<SelectTarefaQueryResponse>(tarefa);
        mappedResponse.Status = tarefa.GetSituacao();

        return mappedResponse;

    }

    public async Task<int> GetIdInclusao() =>
        await _tarefaRepository.GetMaxId() + 1;

    public async Task AddAsync(AddTarefaCommand addTarefaCommand)

    {
        var tarefaEntity = ConstroiTarefaEntity(addTarefaCommand);
        tarefaEntity.SetId(await GetIdInclusao());

        await _tarefaRepository.AddAsync(tarefaEntity);
    }

    private static Tarefa ConstroiTarefaEntity(AddTarefaCommand request) =>
         new Tarefa(
            request.Titulo,
            request.Descricao,
            request.Prazo
            );
}
