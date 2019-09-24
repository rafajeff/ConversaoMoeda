using System;

namespace ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor, dolar;
            decimal resultado;

            Console.WriteLine("Digite a cotação do dolar");
            Console.Write("$");
            dolar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor que deseja converter em dolar");
            Console.Write("$");
            valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"\nO valor é:{valor * dolar:C2} Reais");
        }
    }
}
