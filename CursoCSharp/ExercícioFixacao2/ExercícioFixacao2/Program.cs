using System;
using System.Globalization;

namespace ExercícioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario trab = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário!");

            Console.Write("Nome: ");
            trab.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            trab.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            trab.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(trab.ToString());

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trab.AumentarSalario(porcent);

            Console.WriteLine("Dados Atualizados: "+trab);

        }
    }
}
