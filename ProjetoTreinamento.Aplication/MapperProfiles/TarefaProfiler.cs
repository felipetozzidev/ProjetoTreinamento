using AutoMapper;
using ProjetoTreinamento.Application.Queries.Tarefas.GetAll;
using ProjetoTreinamento.Application.Queries.Tarefas.Select;
using ProjetoTreinamento.Domain.Entities;

namespace ProjetoTreinamento.Application.MapperProfiles;

public class TarefaProfiler : Profile
{
    public TarefaProfiler()
    {
        CreateMap<Tarefa, GetAllTarefaQueryResponse>()
        .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Titulo))
        .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
        .ForMember(dest => dest.Prazo, opt => opt.MapFrom(src => src.Prazo));

        CreateMap<Tarefa, SelectTarefaQueryResponse>()
        .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Titulo))
        .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
        .ForMember(dest => dest.Prazo, opt => opt.MapFrom(src => src.Prazo))
        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

    }
}
