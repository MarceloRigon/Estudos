using System;
using System.Globalization;

namespace ConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double iof = ConversorDeMoeda.DolarParaReal(cotacao, dolar);
            

            Console.WriteLine("Valor a ser pago em reais = "+iof);
              

        }
    }
}
