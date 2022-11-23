using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp2.DataModels
{
    public class Notas
    {
       
        public int id { get; set; }
        public string infoNota { get; set; }
        public int preco { get; set; }
        public int quantidade { get; set; }
        public virtual ICollection<Produtos> produto { get; set; }
        public virtual ICollection<Clientes> clientes { get; set; }

        public virtual ICollection<Fornecedores> fornecedores { get; set; }
    }
}

