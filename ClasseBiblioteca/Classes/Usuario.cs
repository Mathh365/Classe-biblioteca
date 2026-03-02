namespace ClasseBiblioteca;

public class Usuario
{
    public string Nome {get; private set;}
    int ID {get; set;}
    private Livro[] LivrosEmprestados = new Livro[3];

    public Usuario(string nome, int id)
    {
        this.ID = id;
        this.Nome = nome;
    }

    public bool PodeEmprestar()
    {
        if (LivrosEmprestados.Length >= 3) return false;
        if (LivrosEmprestados.Length < 3) return true;
        return false;
    }

    public void AdicionarEmprestado()
    {
        
    }

    public void RemoverDevolvido()
    {
        
    }
}
