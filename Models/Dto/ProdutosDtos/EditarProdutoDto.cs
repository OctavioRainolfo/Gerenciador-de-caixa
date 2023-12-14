using AutoMapper;
using Gerenciador_de_caixa.Models;
using Gerenciador_de_caixa.Models.Dto;

namespace Gerenciador_de_caixa.Models.Dto
{
    public class EditarProdutoDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double? PrecoVenda { get; set; }
        public double? PrecoCompra { get; set; }
        public int? Quantidade { get; set; }
        public string? Descricao { get; set; }
    }
}

public class EditarProdutoDtoProdutoMappingProfile : Profile
{
    public EditarProdutoDtoProdutoMappingProfile()
    {
        CreateMap<EditarProdutoDto, Produto>()
            .ReverseMap();
    }
}