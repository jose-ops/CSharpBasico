using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vect = new string[] { "jose", "maria", "bob" };

            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------");

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
