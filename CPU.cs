
class CPU
{
    public int Nucleos { get; private set; }
    public double FrequenciaGHz { get; private set; }

    public CPU(int nucleos, double freq)
    {
        Nucleos = nucleos;
        FrequenciaGHz = freq;
    }

    public void Executar(Processo p)
    {
        Console.WriteLine($"[CPU] Executando processo {p.Nome} (PID {p.PID})...");
        Thread.Sleep(500);
    }
}