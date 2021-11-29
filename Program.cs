using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07While
{
    class Program
    {
        static void Main(string[] args)
        {

            string resp = "S";
            double valor, total = 0;

            while (resp == "S")
            {
                Console.WriteLine("Informe o valor do produto");
                valor = Double.Parse(Console.ReadLine());

                total += valor;

                Console.WriteLine("Deseja Inserir um novo produto?");
                resp = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("O valor final da venda é: " + total.ToString("C"));
            Console.ReadKey();

        }
    }
}
