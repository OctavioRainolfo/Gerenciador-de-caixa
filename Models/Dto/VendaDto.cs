using AutoMapper;
using Gerenciador_de_caixa.Models;
using Gerenciador_de_caixa.Models.Dto;

namespace Gerenciador_de_caixa.Models.Dto
{
    public class VendaDto
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public required List<TransacaoDto> Transacoes { get; set; }
        public required List<ProdutoDto> Produtos { get; set; }
    }
}

public class VendaDtoVendaMappingProfile : Profile
{
    public VendaDtoVendaMappingProfile()
    {
        CreateMap<VendaDto, Venda>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap();
    }
}