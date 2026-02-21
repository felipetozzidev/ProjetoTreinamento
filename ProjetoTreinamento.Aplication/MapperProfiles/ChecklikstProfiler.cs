using AutoMapper;
using ProjetoTreinamento.Application.Queries.Checklists.GetAllChildren;
using ProjetoTreinamento.Application.Queries.Checklists.Select;
using ProjetoTreinamento.Domain.Entities;

namespace ProjetoTreinamento.Application.MapperProfiles;

public class ChecklistProfiler : Profile
{
    public ChecklistProfiler()
    {
        CreateMap<Checklist, SelectChecklistQueryResponse>()
            .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Titulo))
            .ForMember(dest => dest.IdTarefa, opt => opt.MapFrom(src => src.IdTarefa))
            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao));

        CreateMap<Item, GetAllChecklistChildrenQueryResponse>()
            .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Titulo));

    }
}
