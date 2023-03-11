using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);//quantidade de elementos total
            Console.WriteLine(mat.Rank);//primeira dimençao da matriz
            Console.WriteLine(mat.GetLength(0));//tamamho primeira dimencao
            Console.WriteLine(mat.GetLength(1));//tamanho na segunda dimençao
        }
    }
}
