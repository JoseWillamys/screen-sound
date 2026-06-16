using System.Threading.Channels;

class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    private List<string> convidados = [];
    public string Titulo { get; }
    public int Ordem {  get; }
    public int Duracao { get;  }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - Convidados: " + string.Join(", ", convidados);

    public void AdicionarConvidados (string convidado)
    {
        convidados.Add(convidado);
    }
}