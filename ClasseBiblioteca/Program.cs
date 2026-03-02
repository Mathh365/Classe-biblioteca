using ClasseBiblioteca;
Console.Clear();
Biblioteca bib = new Biblioteca();
bib.AddLivro(1019, "chapeuzinho vermelho", "autor1");
bib.AddLivro(1219, "trez porquinhos", "autor2");
bib.AddLivro(1240, "codigo limpo", "autor3");
bib.AddLivro(1030, "a sutil arte de ligar o fodase", "autor4");
bib.AddLivro(9020, "scrum", "autor5");

bib.AddUsuario("pedro");
bib.AddUsuario("maria");
// bib.ListarUsuarios();
// bib.ListarLivros();

bib.EmprestarLivro(2, bib.ListaDeLivros[1]);
bib.EmprestarLivro(2, bib.ListaDeLivros[4]);
Console.WriteLine(bib.ListaDeUsuarios[1].Infos());