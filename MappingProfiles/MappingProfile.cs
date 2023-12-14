﻿using AutoMapper;
using Gerenciador_de_caixa.Models;
using Gerenciador_de_caixa.Models.Dto;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Produto, ProdutoDto>().ReverseMap();
        CreateMap<Transacao, TransacaoDto>().ReverseMap();
        CreateMap<Venda, VendaDto>().ReverseMap();
        CreateMap<PrestacaoDeServicos, PrestacaoDeServicosDto>().ReverseMap();
    }
}
