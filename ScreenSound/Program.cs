Album albumToxicity = new() { Nome = "Toxicity" };

Musica musica1 = new()
{
    Nome = "Prinson Song",
    Artista = "System of a Down",
    Duracao = 273,
    Disponivel = true,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica2 = new()
{
    Nome = "Chop Suey!",
    Artista = "System of a Down",
    Duracao = 210,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica3 = new()
{
    Nome = "Bounce",
    Artista = "System of a Down",
    Duracao = 114,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica4 = new()
{
    Nome = "Toxicity",
    Artista = "System of a Down",
    Duracao = 218,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

Musica musica5 = new()
{
    Nome = "Aerials",
    Artista = "System of a Down",
    Duracao = 235,
    Disponivel = false,
    Genero = new Genero { Nome = "Rock" }
};

albumToxicity.AdicionarMusica(musica1);
albumToxicity.AdicionarMusica(musica2);
albumToxicity.AdicionarMusica(musica3);
albumToxicity.AdicionarMusica(musica4);
albumToxicity.AdicionarMusica(musica5);

albumToxicity.ExibirMusicas();
