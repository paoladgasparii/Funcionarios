using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int continuar = 1;
            double salarioliquido = 0;
            double folhapagamento = 0;
            

            while (continuar == 1)
            {
                Console.WriteLine("Insira a forma de contratação (A)ssalariado (C)omissionado (H)orista: ");
                string contratacao = Console.ReadLine();

                switch (contratacao)
                {
                    case "A":
                        Console.WriteLine("Digite o valor do salário bruto: ");
                        double salariob = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do desconto: ");
                        double desc = double.Parse(Console.ReadLine());

                        salarioliquido = salariob - desc;
                        break;

                    case "C":
                        Console.WriteLine("Digite a quantidade de peças produzidas: ");
                        int pecas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor recebido por peça: ");
                        double valorpecas = double.Parse(Console.ReadLine());

                        salarioliquido = pecas * valorpecas;
                        break;

                    case "H":
                        Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                        int hora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor recebido por hora: ");
                        double valorhora = double.Parse(Console.ReadLine());

                        salarioliquido = hora * valorhora;
                        break;
                }

                Console.WriteLine("Deseja continuar? (1)Sim (2)Não: ");
                continuar = int.Parse(Console.ReadLine());
                cont++;
                salarioliquido++;
                folhapagamento++;
                folhapagamento = folhapagamento + salarioliquido;

            }

            double mediasalarial = folhapagamento / cont;
            Console.WriteLine("Folha de pagamento R$: " + folhapagamento);
            Console.WriteLine("Funcionários cadastrados: " + cont);
            Console.WriteLine("Média salarial R$: " + mediasalarial);

            Console.ReadKey();

        }
    }
}
