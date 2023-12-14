using AutoMapper;
using Gerenciador_de_caixa.Models;
using Gerenciador_de_caixa.Models.Dto;

namespace Gerenciador_de_caixa.Models.Dto
{
    public class TransacaoDto
    {
        public int Id { get; set; }
        public required string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}

public class TransacaoDtoTransacaoMappingProfile : Profile
{
    public TransacaoDtoTransacaoMappingProfile()
    {
        CreateMap<TransacaoDto, Transacao>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap();
    }
}