using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== DIAGNÓSTICO DE SERVIDOR ===\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MENU DE COMANDOS:");
            Console.WriteLine("1 - Testar conexão (Ping)");
            Console.WriteLine("2 - Formatar unidade");
            Console.WriteLine("3 - Reiniciar servidor");
            Console.WriteLine("? - Ajuda (Documentação)");
            Console.WriteLine("0 - Sair");
            Console.ResetColor();

            Console.Write("\nEscolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "?":
                case "help":
                MostrarAjuda();
                break;
                case "1":
                    TestarConexao();
                    break;

                case "2":
                    FormatarUnidade();
                    break;

                case "3":
                    ReiniciarServidor();
                    break;

                case "0":
                    Console.WriteLine("Encerrando sistema...");
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }

    static void TestarConexao()
    {
        Console.WriteLine("\nFormato esperado: 192.168.0.1");
        Console.Write("Digite o IP de destino: ");
        string ip = Console.ReadLine();

        if (string.IsNullOrEmpty(ip) || !ip.Contains("."))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("IP inválido!");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nEnviando pacotes para {ip}...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Resposta recebida! Latência: 15ms.");
        Console.ResetColor();
    }

    static void FormatarUnidade()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nDeseja formatar a unidade? (Sim/Não)");
        string formatar = Console.ReadLine();

        if (formatar.Equals("Sim", StringComparison.OrdinalIgnoreCase))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ATENÇÃO: Esta ação apagará TODOS os dados!");
            Console.WriteLine("Digite 'CONFIRMAR' para continuar:");
            string confirmacao = Console.ReadLine();

            if (confirmacao == "CONFIRMAR")
            {
                Console.WriteLine("Formatando unidade...");
                System.Threading.Thread.Sleep(3000);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Unidade formatada com sucesso!");
            }
            else
            {
                Console.WriteLine("Formatação cancelada.");
            }
        }
        else
        {
            Console.WriteLine("Operação cancelada.");
        }

        Console.ResetColor();
    }

    static void ReiniciarServidor()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nDeseja realmente reiniciar o servidor? (Sim/Não)");
        string resposta = Console.ReadLine();

        if (resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Digite 'REINICIAR' para confirmar:");
            string confirmacao = Console.ReadLine();

            if (confirmacao == "REINICIAR")
            {
                Console.WriteLine("Reiniciando servidor...");
                System.Threading.Thread.Sleep(3000);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Servidor reiniciado com sucesso!");
            }
            else
            {
                Console.WriteLine("Reinicialização cancelada.");
            }
        }
        else
        {
            Console.WriteLine("Operação cancelada.");
        }

        Console.ResetColor();
    }
    static void MostrarAjuda()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n--- AJUDA E DOCUMENTAÇÃO ---");
    Console.WriteLine("1 (Ping): Simula o teste de conectividade com um endereço IP.");
    Console.WriteLine("2 (Formatar): Simula a limpeza de dados (exige confirmação por escrito).");
    Console.WriteLine("3 (Reiniciar): Simula o reboot do sistema (exige confirmação por escrito).");
    Console.WriteLine("0 (Sair): Encerra a aplicação de diagnóstico.");
    Console.WriteLine("-----------------------------");
    Console.ResetColor();
}
}