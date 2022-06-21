using System;
using System.Globalization;

namespace ExercícioFixação
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo medida = new Retangulo();
            
            Console.Write("Entre a largura e a altura do retângulo: ");

            medida.Largura = double.Parse(Console.ReadLine());
            medida.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + medida.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + medida.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + medida.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
