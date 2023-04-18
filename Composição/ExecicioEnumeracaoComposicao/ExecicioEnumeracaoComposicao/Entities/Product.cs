using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioEnumeracaoComposicao.Entities
{
    class Product
    {
        public string name { get; set; }
        public double preco { get; set; }

        public Product()
        {

        }

        public Product(string name, double preco)
        {
            this.name = name;
            this.preco = preco;
        }
    }
}
