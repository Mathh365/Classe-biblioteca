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
        foreach(var item in ListaDeLivros) Console.WriteLine(item.Info());
    }

    public void EmprestarLivro(int idDoUsuario, Livro livro)
    {
        Usuario user = ListaDeUsuarios[idDoUsuario - 1];
        if (user.PodeEmprestar()) livro.Emprestar(user);
        else Console.WriteLine("Voce ja tem 3 livros, por favor devolva um antes de emprestar um novo");
    }

    public void DevolverLivro(int idDoUsuario, Livro livro)
    {
        Usuario user = ListaDeUsuarios[idDoUsuario - 1];
        if (user.LivrosEmprestados.Contains(livro)) livro.Devolver(user);
        else Console.WriteLine("Este usuario nao esta na posse deste livro");
    }

    public void LivrosDoUsuario(int idDoUsuario)
    {
        Usuario user = ListaDeUsuarios[idDoUsuario - 1];
        int indice = 0;

        Console.WriteLine($"\nLivros do usuario {user.Nome}");

        foreach (var item in user.LivrosEmprestados)
        {
            indice++;
            Console.WriteLine($"{indice} - {item.Titulo} / ISBN: {item.Isbn}");            
        }
    }
}
