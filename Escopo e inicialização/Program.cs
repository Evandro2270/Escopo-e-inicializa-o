using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                double desconto = 0.0;
                double preco = double.Parse(Console.ReadLine());

                if (preco > 100.0)
                {
                    desconto = preco * 0.1;
                }
                Console.WriteLine(desconto);

            }
        }
    }
}