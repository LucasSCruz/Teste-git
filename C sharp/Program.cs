using System;
using System.Globalization;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            if (preco < 20)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);
        }
    }
}
