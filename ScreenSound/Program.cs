Album Toxicity   = new Album();

Musica musica1 = new Musica();
musica1.Nome = "Prinson Song";
musica1.Artista = "System of a Down";
musica1.Duração = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Chop Suey!";
musica2.Artista = "System of a Down";
musica2.Duração = 210;
musica2.Disponivel = false;

Musica musica3 = new Musica();
musica2.Nome = "Bounce";
musica2.Artista = "System of a Down";
musica2.Duração = 114;
musica2.Disponivel = false;

Musica musica4 = new Musica();
musica2.Nome = "Toxicity";
musica2.Artista = "System of a Down";
musica2.Duração = 218;
musica2.Disponivel = false;

Musica musica5 = new Musica();
musica2.Nome = "Aerials";
musica2.Artista = "System of a Down";
musica2.Duração = 235;
musica2.Disponivel = false;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
album1.AdicionarMusica(musica3);
album1.AdicionarMusica(musica4);
album1.AdicionarMusica(musica5);

/*
musica1.ExibirFichaTecnica();
Console.WriteLine("");
musica2.ExibirFichaTecnica();*/