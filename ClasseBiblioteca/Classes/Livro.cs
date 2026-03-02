namespace ClasseBiblioteca;

public class Livro
{
    public string Titulo {get; set;}
    public string Autor {get; set;}
    public int Isbn {get; set;}
    public bool IsEmprestado {get; private set;} = false;
    private Usuario? Possuidor;

    public Livro(int isbn, string titulo, string autor)
    {
        this.Autor = autor;
        this.Titulo = titulo;
        this.Isbn = isbn;
    }

    public void Emprestar(Usuario user)
    {
        if (IsEmprestado)
        {
            Console.WriteLine("Este livro ja esta emprestado por outra pessoa");
        }
        else
        {
            Console.WriteLine($"Livro {this.Titulo} disponivel para emprestimo, transferindo para {user.Nome}");
            Possuidor = user;
            IsEmprestado = true;
            user.AdicionarEmprestado(this);
        }
    }
    public void Devolver()
    {
        
    }

    public string Info()
    {
        return ($"Titulo: {this.Titulo} / ISBN: {this.Isbn} / Autor: {this.Autor} / Esta emprestado? {IsEmprestado}");
    }
}
