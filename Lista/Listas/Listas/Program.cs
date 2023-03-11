using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("jose");
            list.Add("maria");
            list.Add("carlos");
            list.Add("ana");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"quantidade na lista {list.Count}");

            string s1 = list.Find(x => x[0] == 'A');//mesma coisa d afunçao 'Test'

            Console.WriteLine($"primeiro com 'A:' {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Primeiro postiçao q começa com 'A' {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Ultima postiçao q começa com 'A' {pos1}");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }



        //static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}
