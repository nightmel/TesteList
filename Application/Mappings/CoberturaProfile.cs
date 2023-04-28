using AutoMapper;
using Domain.Entities;
using Application.Interfaces.Models;

public class CoberturaProfile : Profile
{
    public CoberturaProfile()
    {
        CreateMap<Cobertura, CoberturaViewModel>();
        CreateMap<CoberturaViewModel, Cobertura>();
    }
}
