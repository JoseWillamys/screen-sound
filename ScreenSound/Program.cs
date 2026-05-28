Album albumToxicity = new Album();

Musica musica1 = new Musica();
musica1.Nome = "Prinson Song";
musica1.Artista = "System of a Down";
musica1.Duração = 273;
musica1.Disponivel = true;

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

albumToxicity.AdicionarMusica(musica1);
albumToxicity.AdicionarMusica(musica2);
albumToxicity.AdicionarMusica(musica3);
albumToxicity.AdicionarMusica(musica4);
albumToxicity.AdicionarMusica(musica5);

albumToxicity.ExibirMusicas();
