Banda systemOfADown = new() { Nome = "System of a Down" };
Album albumToxicity = new() { Nome = "Toxicity" };

Musica musica1 = new(systemOfADown)
{
    Nome = "Prinson Song",
    Duracao = 273,
    Disponivel = true,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica2 = new(systemOfADown)
{
    Nome = "Chop Suey!",
    Duracao = 210,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica3 = new(systemOfADown)
{
    Nome = "Bounce",
    Duracao = 114,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica4 = new(systemOfADown)
{
    Nome = "Toxicity",
    Duracao = 218,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica5 = new(systemOfADown)
{
    Nome = "Aerials",
    Duracao = 235,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

albumToxicity.AdicionarMusica(musica1);
albumToxicity.AdicionarMusica(musica2);
albumToxicity.AdicionarMusica(musica3);
albumToxicity.AdicionarMusica(musica4);
albumToxicity.AdicionarMusica(musica5);

systemOfADown.AdicionarAlbum(albumToxicity);
systemOfADown.ExibirDiscografia();