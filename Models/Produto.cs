namespace Gerenciador_de_caixa.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoCompra { get; set; }
        public int Quantidade { get; set; }
        public string? Descricao { get; set; }
    }
}
