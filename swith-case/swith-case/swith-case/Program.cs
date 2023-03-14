using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swith_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x)
            {
                case 1:
                    day = "SegundaDay";
                    break;
                case 2:
                    day = "TerçaDay";
                    break;
                case 3:
                    day = "QuartaDay";
                    break;
                case 4:
                    day = "QuintaDay";
                    break;
                case 5:
                    day = "SabadoDay";
                    break;
                case 6:
                    day = "DomingoDay";
                    break;
                default:
                    day = "Dia Invalido";
                    break;
            }
            Console.WriteLine($"DiaDay: {day}");
        }
    }
}
