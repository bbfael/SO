
class Disco
{
    public int CapacidadeGB { get; private set; }
    private List<string> arquivos = new();

    public Disco(int capacidade)
    {
        CapacidadeGB = capacidade;
    }

    public void CriarArquivo(string nome)
    {
        arquivos.Add(nome);
        Console.WriteLine($"[DISCO] Arquivo '{nome}' criado.");
    }

    public void ListarArquivos()
    {
        Console.WriteLine("[DISCO] Arquivos:");
        if (arquivos.Count == 0)
            Console.WriteLine(" (nenhum arquivo)");
        foreach (var a in arquivos)
            Console.WriteLine(" - " + a);
    }
}