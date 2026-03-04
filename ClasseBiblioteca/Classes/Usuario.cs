namespace ClasseBiblioteca;

public class Usuario
{
    public string Nome {get; private set;}
    public int ID {get; private set;}
    public List<Livro> LivrosEmprestados {get; private set;} = new List<Livro>();

    public Usuario(string nome, int id)
    {
        this.ID = id;
        this.Nome = nome;
    }

    public bool PodeEmprestar()
    {
        return (LivrosEmprestados.Count < 3);
    }

    public void AdicionarEmprestado(Livro livro)
    {
        LivrosEmprestados.Add(livro);
    }

    public void RemoverDevolvido(Livro livro)
    {
        LivrosEmprestados.Remove(livro);
    }

    public string Infos()
    {
        return ($"Nome: {this.Nome} / ID: {this.ID} / Livros emprestados: {LivrosEmprestados.Count}");
    }
}
