class Musica
{
    public string nome;
    public string artista;
    public int duração;
    public bool disponivel;

    public void ExibirFichaTecnica ()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duração}");

        if (disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}