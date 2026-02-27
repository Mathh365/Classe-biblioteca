using System;
using System.Runtime.CompilerServices;

namespace ClasseBiblioteca;

public class Livro
{
    public string Titulo {get; set;}
    public string Autor {get; set;}
    public int Isbn {get; set;}
    public bool _isEmprestado {get; set;} = false;

    public Livro(int isbn, string titulo, string autor)
    {
        this.Autor = autor;
        this.Titulo = titulo;
        this.Isbn = isbn;
    }
    public void Emprestar()
    {
        
    }

    public void Devolver()
    {
        
    }
}
