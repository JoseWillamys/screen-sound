class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome {  get; set; }
    public int DuracaoTotal { get; set; }
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas ()
    {
        foreach (Musica musica in musicas)
        {
            Console.WriteLine(musica.DescricaoResumida);
        }
    }
}