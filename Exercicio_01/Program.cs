using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.
            int n;

            Console.Write("Digite o número: "); //Imprime um valor na tela
            n = Convert.ToInt32(Console.ReadLine()); //Lê e converte para int o número informado pelo usuário

            if (n % 2 == 0)
            {
                Console.WriteLine("É par");
            }
            else
            {
                Console.WriteLine("É impar");
            }
            Console.ReadKey();
        }
    }
}
