
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MiniErp2.DataModels
{
    public class Pedido
    {
       
        public int id { get; set; }
        public int preco { get; set; }
        public DateTime data { get; set; }
        public int quantidade { get; set; }
       
        public virtual Clientes cliente { get; set; }
        public virtual Produtos produtos { get; set; }
        public virtual Notas nota { get; set; }


    }
}