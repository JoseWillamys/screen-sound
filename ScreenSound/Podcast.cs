class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    private List<Episodio> episodios = [];

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodios(Episodio novoEpisodio)
    {
        episodios.Add(novoEpisodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo + "\n");
        }
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
}