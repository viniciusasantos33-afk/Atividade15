namespace Atividade15.Models;

public class Filme
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

    public int DuracaoEmMinutos { get; set; }

    public int DiretorId { get; set; }
    public Diretor Diretor { get; set; } = null!;

    public ICollection<Genero> Generos { get; set; } = new List<Genero>();
}