namespace ClasseBiblioteca;

public class Livro
{
    public string Titulo {get; set;}
    public string Autor {get; set;}
    public int Isbn {get; set;}
    public bool IsEmprestado {get; private set;} = false;

    public Livro(int isbn, string titulo, string autor)
    {
        this.Autor = autor;
        this.Titulo = titulo;
        this.Isbn = isbn;
    }

    public void Emprestar()
    {
        if (IsEmprestado)
        {
            Console.WriteLine("Este livro ja esta emprestado por outra pessoa");
        }
        else
        {
            Console.WriteLine("Livro livre, emprestando neste momento");
            IsEmprestado = true;
        }
    }
    public void Devolver()
    {
        
    }
}
