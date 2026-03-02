using ClasseBiblioteca;
Console.Clear();
Biblioteca bib = new Biblioteca();


Usuario teste = new Usuario("Marcos", 1);
bib.AddUsuario(teste);
bib.ListarUsuarios();