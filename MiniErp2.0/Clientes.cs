using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp2.DataModels
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public virtual ICollection<Produtos> produtos { get; set; }
        public virtual Notas notas { get; set; }



    }
}
