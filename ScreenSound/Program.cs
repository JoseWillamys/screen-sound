/*
Genero rock = new("Rock 'n Roll");
Banda systemOfADown = new("System of a Down");
Album albumToxicity = new("Toxicity");

Musica musica1 = new(systemOfADown, "Prinson Song", rock)
{
    Duracao = 273,
    Disponivel = true,
};

Musica musica2 = new(systemOfADown, "Chop Suey!", rock)
{
    Duracao = 210,
    Disponivel = false,
};

Musica musica3 = new(systemOfADown, "Bounce", rock)
{
    Duracao = 114,
    Disponivel = false
};

Musica musica4 = new(systemOfADown, "Toxicity", rock)
{
    Duracao = 218,
    Disponivel = false
};

Musica musica5 = new(systemOfADown, "Aerials", rock)
{
    Duracao = 235,
    Disponivel = false
};

albumToxicity.AdicionarMusica(musica1);
albumToxicity.AdicionarMusica(musica2);
albumToxicity.AdicionarMusica(musica3);
albumToxicity.AdicionarMusica(musica4);
albumToxicity.AdicionarMusica(musica5);
systemOfADown.AdicionarAlbum(albumToxicity);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();

albumToxicity.ExibirMusicas();
systemOfADown.ExibirDiscografia();
*/

Episodio ep1 = new(1, "Corridas de rua", 20);
ep1.AdicionarConvidados("Marta");
ep1.AdicionarConvidados("Jonas");

Episodio ep2 = new(2, "Impacto das Redes sociais no jovens", 35);
ep2.AdicionarConvidados("Santana");
ep2.AdicionarConvidados("Claudio");

Podcast podcast = new("José Marcos", "Atualidades Modernas");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDetalhes();