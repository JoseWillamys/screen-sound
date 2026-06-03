class Musica
{
    public string Nome {  get; set; }
    public string Artista { get; set;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
    public Genero Genero {  get; set; }

    public void ExibirFichaTecnica ()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero.Nome}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}