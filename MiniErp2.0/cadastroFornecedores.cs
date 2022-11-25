using MiniErp2.DataModels;
using System;
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
    public partial class Form_fornecedores : Form
    {
        public Form_fornecedores()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaInicial frm = new TelaInicial();
            frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cadastroClientes frm = new cadastroClientes();
            frm.Show();
        }

        private void button_GravarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();

                Fornecedores f = new Fornecedores();

                f.cnpj = textBox_cnpjFornecedor.Text;
                f.nome = textBox_NomeFornecedor.Text;
                f.telefone = textBox_telefoneFornecedor.Text;
                f.id = int.Parse(textBox_idFornecedor.Text);
                

                
                contexto.fornecedor.Add(f);
                contexto.SaveChanges();
                MessageBox.Show("fornecedor inserida com sucesso");

            }
            catch (Exception ex)


            {
                MessageBox.Show("error");
            }
        }
    }
}
