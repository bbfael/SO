using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;


class SistemaOperacional
{
    private CPU cpu;
    private RAM ram;
    private Disco disco;
    private List<Processo> processos = new();

    public SistemaOperacional(CPU cpu, RAM ram, Disco disco)
    {
        this.cpu = cpu;
        this.ram = ram;
        this.disco = disco;
    }

    public void InstalarPrograma(string nome, int memoria)
    {
        var p = new Processo(nome, memoria);
        if (ram.Alocar(memoria))
        {
            processos.Add(p);
            disco.CriarArquivo(nome + ".exe");
            Console.WriteLine($"[SO] Programa {nome} instalado e carregado na memória ({memoria}MB).");
        }
        else
        {
            Console.WriteLine("[SO] Memória insuficiente!");
        }
    }

    public void ExecutarProcessos()
    {
        if (processos.Count == 0)
        {
            Console.WriteLine("[SO] Nenhum processo para executar.");
            return;
        }

        foreach (var p in processos)
        {
            cpu.Executar(p);
        }
    }

    public void ListarProcessos()
    {
        Console.WriteLine("[SO] Processos ativos:");
        if (processos.Count == 0)
        {
            Console.WriteLine(" (nenhum processo)");
            return;
        }

        foreach (var p in processos)
            Console.WriteLine($" - {p.Nome} (PID {p.PID}, Mem {p.MemoriaNecessaria}MB)");
    }

    public void Status()
    {
        Console.WriteLine("\n=== STATUS DO SISTEMA ===");
        ram.Status();
        disco.ListarArquivos();
        ListarProcessos();
        Console.WriteLine("=========================\n");
    }
}