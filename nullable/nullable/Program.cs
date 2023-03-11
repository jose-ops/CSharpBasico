using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {

          //Nullable<double> x = null; aceita null

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;
            double b = x ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(x.GetValueOrDefault()); //GetValueOrDefault() otberValorOuPadrao
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(y.HasValue); 
            Console.WriteLine(x.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is Null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            Console.WriteLine("y is Null");
        }
    }
}
