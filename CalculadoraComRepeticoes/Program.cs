using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComRepeticoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---CALCULADORA----");
            Console.Write("Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int opcao;
            double resultado;
            char continuar;

            do
            {

                Console.WriteLine("Opções:\n[ 1 ] Adição\n[ 2 ] Subtração\n[ 3 ] Multiplicação\n[ 4 ] Divisão\n[ 5 ] Novos números\n[ 6 ] Sair do programa");
                Console.Write("Escolha:");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 1 || opcao > 6)
                {
                    Console.WriteLine("Opção Invalida!!");
                    Console.WriteLine("Opções:\n[ 1 ] Adição\n[ 2 ] Subtração\n[ 3 ] Multiplicação\n[ 4 ] Divisão\n[ 5 ] Novos números\n[ 6 ] Sair do programa");
                    Console.Write("Escolha:");
                    opcao = int.Parse(Console.ReadLine());
                }


                if (opcao == 1)
                {
                    resultado = numero1 + numero2;
                    Console.WriteLine($"O resultado de {numero1} + {numero2} = {resultado}");
                }
                else if (opcao == 2)
                {
                    resultado = numero1 - numero2;
                    Console.WriteLine($"O resultado de {numero1} - {numero2} = {resultado}");
                }
                else if (opcao == 3)
                {
                    resultado = numero1 * numero2;
                    Console.WriteLine($"O resultado de {numero1} X {numero2} = {resultado}");
                }
                else if (opcao == 4)
                {
                    if (numero2 != 0)
                    {
                        resultado = (double)numero1 / numero2;
                        Console.WriteLine($"O resultado de {numero1} / {numero2} = {Math.Round(resultado, 2)}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                }
                else if (opcao == 5)
                {
                    Console.Write("Primeiro número: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Segundo número: ");
                    numero2 = int.Parse(Console.ReadLine());


                }

                if (opcao != 6)
                {
                    Console.Write("Deseja continuar? (s/n): ");
                    continuar = char.Parse(Console.ReadLine());

                    while (continuar != 's' && continuar != 'n')
                    {
                        Console.WriteLine("Opção Inválida");
                        Console.Write("Deseja continuar? (s/n): ");
                        continuar = char.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                }
                else
                {
                    continuar = 'n';
                }

            } while (continuar == 's');

            if (continuar == 'n')
            {
                Console.WriteLine("Saindo do programa");
            }


            Console.ReadKey();
        }
    }
}
