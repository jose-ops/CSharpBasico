using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioEnumeracaoComposicao.Entities
{
    class Cliente
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime bithDate { get; set; }

        public Cliente()
        {

        }

        public Cliente(string name, string email, DateTime bithDate)
        {
            this.name = name;
            this.email = email;
            this.bithDate = bithDate;
        }

        public override string ToString()
        {
            return $"Name, {bithDate.ToString("dd/MM/yyyy")}, {email}";
        }
    }
}
