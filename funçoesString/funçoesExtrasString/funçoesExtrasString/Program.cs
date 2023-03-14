using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funçoesExtrasString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper(); // TUDO PARA MAIUSCULO

            string s2 = original.ToLower(); // TUDO PARA MINUSCULO

            string s3 = original.Trim(); // apagar espacos em branco 

            int n1 = original.IndexOf("bc"); //procura a POSICAO aonde obtenha `BC`

            int n2 = original.LastIndexOf("bc");//procura a ultima POSICAO aonde obtenha `BC`

            string s4 = original.Substring(3); // cortar string apartir da posiçao 3 

            string s5 = original.Substring(3, 5); // cortar 5 caracteres apartir da posicao 3

            string s6 = original.Replace('a', 'x'); // subistituir 'a' por 'x'

            string s7 = original.Replace("abc", "xy"); //subistituir "abc" por "xy"

            bool b1 = String.IsNullOrEmpty(original); // se nulo ou vazio       `nao eh a mesma coisa`  

            bool b2 = String.IsNullOrWhiteSpace(original);// se nulo ou espacos em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
