using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniErp2.DataModels
{
    public class Fornecedores
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public virtual ICollection<Produtos> produto { get; set; }

    }
}

