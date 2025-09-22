

class Programa
{
    static void Main(string[] args)
    {
        CPU cpu = new CPU(4, 3.5);
        RAM ram = new RAM(8192);
        Disco disco = new Disco(256);

        SistemaOperacional so = new SistemaOperacional(cpu, ram, disco);

        bool rodando = true;
        while (rodando)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Instalar programa");
            Console.WriteLine("2 - Listar processos");
            Console.WriteLine("3 - Executar processos");
            Console.WriteLine("4 - Status do sistema");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do programa: ");
                    string nome = Console.ReadLine();
                    Console.Write("Memória necessária (MB): ");
                    int mem = int.Parse(Console.ReadLine());
                    so.InstalarPrograma(nome, mem);
                    break;

                case "2":
                    so.ListarProcessos();
                    break;

                case "3":
                    so.ExecutarProcessos();
                    break;

                case "4":
                    so.Status();
                    break;

                case "5":
                    rodando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}