﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp2.DataModels
{
    public class Produtos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int preco { get; set; }
        public int quantidade { get; set; }
        public virtual Fornecedores fornecedor { get; set; }

        public virtual Clientes clientes { get; set; }

        public virtual Notas notas { get; set; }
    }
}

