using System.Globalization;

namespace Exercicio4;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------ Escolha como você quer a data atual--------");
        Console.WriteLine("[1] Formato completo");
        Console.WriteLine("[2] Formato dd/mm/aaaa");
        Console.WriteLine("[3] Apenas a hora");
        Console.WriteLine("[4] Data com o mês por extenso");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                {
                    DateTime hoje = DateTime.Now;
                    Console.WriteLine(hoje.ToString("F", new CultureInfo("pt-BR")));
                }
                break;
            case "2":
                {
                    DateTime hoje = DateTime.Today;
                    string dataTexto = hoje.ToString("d", new CultureInfo("pt-BR"));
                    Console.Write(dataTexto);
                }
                break;
            case "3":
                {
                    DateTime hoje = DateTime.Now;
                    string horaTexto = hoje.ToString("t", new CultureInfo("pt-BR"));
                    Console.Write(horaTexto);
                }
                break;
            case "4":
                {
                    DateTime hoje = DateTime.Now;
                    string dataTexto = hoje.ToString("D", new CultureInfo("pt-BR"));
                    Console.Write(dataTexto);
                }
            break;
            default:
                {
                    Console.WriteLine("Opção inválida");
                }
                break;
        }
    }
}