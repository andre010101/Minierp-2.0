﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniErp2._0
{
    public partial class cadastroClientes : Form
    {
        public cadastroClientes()
        {
            InitializeComponent();
        }


      
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            TelaInicial frm = new TelaInicial();
            frm.Show();
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_fornecedores frm = new Form_fornecedores();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cadastroDeProdutos frm = new cadastroDeProdutos();
            frm.Show();
        }
    }
}