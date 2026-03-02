using System.Reflection.Metadata;

namespace ClasseBiblioteca;

public class Biblioteca
{
        private int ID = 0;
        public List<Livro> ListaDeLivros {get; private set;} = new List<Livro>();
        public List<Usuario> ListaDeUsuarios {get; private set;} = new List<Usuario>();
    

    public void AddUsuario(string nome)
    {
        ID ++;
        ListaDeUsuarios.Add(new Usuario(nome, ID));
    }
    
    public void AddLivro(int isbn, string titulo, string autor)
    {
        ListaDeLivros.Add(new Livro(isbn, titulo, autor));
    }

    public void ListarUsuarios()
    {
        int indice = 0;
        Console.WriteLine("Lista de usuarios da biblioteca: \n");
        foreach (var item in ListaDeUsuarios)
        {
            indice++;
            Console.WriteLine($"{indice} - {item.Infos()}");
        }
    }

    public void ListarLivros()
    {
        foreach(var item in ListaDeLivros)
        {
            Console.WriteLine(item.Info());
        }
    }

    public void EmprestarLivro(int id, Livro livro)
    {
        Usuario user = ListaDeUsuarios[id - 1];
        if (user.PodeEmprestar())
        {
            livro.Emprestar(user);
        }
    }
}
