using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLIsta
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios(int id, string name, double salary)
        {
            Id = id;
            Nome = name;
            Salario = salary;
        }

        public void IncreatarSalario(double percentage)
        {
            Salario += Salario * percentage / 100.0;
        }
        public void PorcentagemSalarial(double porcent)
        {
            Salario = porcent;
        }
    }
}
