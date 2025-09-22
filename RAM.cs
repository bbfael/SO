﻿class RAM
{
    public int CapacidadeMB { get; private set; }
    private int usadoMB = 0;

    public RAM(int capacidade)
    {
        CapacidadeMB = capacidade;
    }

    public bool Alocar(int mb)
    {
        if (usadoMB + mb <= CapacidadeMB)
        {
            usadoMB += mb;
            return true;
        }
        return false;
    }

    public void Liberar(int mb)
    {
        usadoMB = Math.Max(0, usadoMB - mb);
    }

    public int UsadoMB => usadoMB;

    public void Status()
    {
        Console.WriteLine($"[RAM] Usado: {usadoMB}MB / {CapacidadeMB}MB");
    }
}