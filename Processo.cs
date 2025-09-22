class Processo
{
    private static int contadorPID = 1;
    public int PID { get; private set; }
    public string Nome { get; private set; }
    public int MemoriaNecessaria { get; private set; }

    public Processo(string nome, int memoria)
    {
        PID = contadorPID++;
        Nome = nome;
        MemoriaNecessaria = memoria;
    }
}
