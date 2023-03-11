using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum( 2, 3 );
            int s2 = Calculator.Sum( 2, 4, 3 );
        }
    }
}
