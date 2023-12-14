namespace Gerenciador_de_caixa.Models;

public class PrestacaoDeServicos
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public double Valor { get; set; }
    public string? Descricao { get; set; }

}
