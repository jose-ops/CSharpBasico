using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLIsta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("quantos fucnionarios:");
            var n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"funcionario #{i+1}");
                Console.WriteLine("--------------------");
                Console.Write("id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("nome:");
                string nome = Console.ReadLine();
                Console.Write("salario:");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                list.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("indique o funcionario q recebera o aumento: ");
            int ProcuraId = int.Parse(Console.ReadLine());

            Funcionarios funcionarios = list.Find(x => x.Id == ProcuraId);
            if(funcionarios != null)
            {
                Console.WriteLine("");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.IncreatarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("fucnionario nao existe");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach(Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

