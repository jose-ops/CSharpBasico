using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modicaficadorREF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);//REF modificador de parametro
            Console.WriteLine(a);
        }
    }
}
