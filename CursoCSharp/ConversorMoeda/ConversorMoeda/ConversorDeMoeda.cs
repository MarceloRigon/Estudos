
namespace ConversorMoeda
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;
        public static double DolarParaReal(double d, double c) {
            double total = d * c;
            return total + total * IOF / 100;
        }
    }
}
