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
        public int Nfnumero { get; set; }
        public string infoNota { get; set; }
        public int total { get; set; }
       
        public virtual ICollection<Pedido> pedidos { get; set; }

       
    }
}

