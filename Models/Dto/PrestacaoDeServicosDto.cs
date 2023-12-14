using AutoMapper;
using Gerenciador_de_caixa.Models;
using Gerenciador_de_caixa.Models.Dto;

namespace Gerenciador_de_caixa.Models.Dto
{
    public class PrestacaoDeServicosDto
    {
        public int Id { get; set; }
        public DateTime DataPrestacao { get; set; }
        public decimal ValorTotal { get; set; }
        public required List<TransacaoDto> Transacoes { get; set; }
        public required List<ProdutoDto> Produtos { get; set; }
    }
}

public class PrestacaoDeServicosDtoPrestacaoDeServicosMappingProfile : Profile
{
    public PrestacaoDeServicosDtoPrestacaoDeServicosMappingProfile()
    {
        CreateMap<PrestacaoDeServicosDto, PrestacaoDeServicos>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap();
    }
}