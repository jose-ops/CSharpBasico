using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("entr o nnumero da conta");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("entre com o titular da conta");
            string titular = Console.ReadLine();
            Console.WriteLine("havera deposito inicial (s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 's')
            {
                Console.WriteLine("entre como valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("dados da conta ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("entre como valor de deposito deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("entre como valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados ");
            Console.WriteLine(conta);
        }
    }
}
