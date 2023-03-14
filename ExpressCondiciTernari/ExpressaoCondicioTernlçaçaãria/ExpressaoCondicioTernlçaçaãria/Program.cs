using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressaoCondicioTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double descoto = (preco < 20.0) ? preco * 0.1 : preco * 0.5;

            //se condiçao der true a primeira condição irá ler o resultado da primiera condição se nao da segunda 

            //if (preco < 20.0)
            //{
            //    descoto = preco * 0.1;
            //}
            //else
            //{
            //    descoto = preco * 0.05;
            //}
            Console.WriteLine(descoto);
        }
    }
}
