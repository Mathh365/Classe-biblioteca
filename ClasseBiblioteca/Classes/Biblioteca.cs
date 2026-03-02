using System.Reflection.Metadata;

namespace ClasseBiblioteca;

public class Biblioteca
{
    public int ID {get; private set;} = 0;
    private List<Livro> ListaDeLivros = new List<Livro>();
    private List<Usuario> ListaDeUsuarios = new List<Usuario>();

    public Biblioteca()
    {
        
    }

    public void AddUsuario(Usuario nome)
    {
        ListaDeUsuarios.Add(nome);
    }

    public void ListarUsuarios()
    {
        int indice = 0;
        Console.WriteLine("Lista de usuarios da biblioteca: \n");
        foreach (var item in ListaDeUsuarios)
        {
            indice++;
            Console.WriteLine($"{indice} - {item.Nome}");
        }
    }

    
}
