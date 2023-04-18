using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composição.Entities
{
    public class Departament
    {
        public string name { get; set; }
        public Departament()
        {

        }

        public Departament(string name)
        {
            this.name = name;
        }
    }
}
