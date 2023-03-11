using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            var qtd = int.Parse(Console.ReadLine());

            double[] vect = new double[qtd];

            for (int i = 0; i < qtd; i++) 
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < qtd; i++)
            {
                sum += vect[i];
            }

            double avg = sum / qtd;

            Console.WriteLine($"media {avg.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
