using AutoMapper;
using Domain.Entities;
using Application.Interfaces.Models;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<Produto, ProdutoViewModel>();
        CreateMap<ProdutoViewModel, Produto>();
    }
}

