Album albumToxicity = new Album();
albumToxicity.Nome = "Toxicity";

Musica musica1 = new Musica();
musica1.Nome = "Prinson Song";
musica1.Artista = "System of a Down";
musica1.Duracao = 273;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Chop Suey!";
musica2.Artista = "System of a Down";
musica2.Duracao = 210;
musica2.Disponivel = false;

Musica musica3 = new Musica();
musica3.Nome = "Bounce";
musica3.Artista = "System of a Down";
musica3.Duracao = 114;
musica3.Disponivel = false;

Musica musica4 = new Musica();
musica4.Nome = "Toxicity";
musica4.Artista = "System of a Down";
musica4.Duracao = 218;
musica4.Disponivel = false;

Musica musica5 = new Musica();
musica5.Nome = "Aerials";
musica5.Artista = "System of a Down";
musica5.Duracao = 235;
musica5.Disponivel = false;

albumToxicity.AdicionarMusica(musica1);
albumToxicity.AdicionarMusica(musica2);
albumToxicity.AdicionarMusica(musica3);
albumToxicity.AdicionarMusica(musica4);
albumToxicity.AdicionarMusica(musica5);

albumToxicity.ExibirMusicas();
