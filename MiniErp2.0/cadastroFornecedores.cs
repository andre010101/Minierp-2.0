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
                
                

                
                contexto.fornecedor.Add(f);
                contexto.SaveChanges();
                MessageBox.Show("fornecedor inserida com sucesso");

            }
            catch (Exception ex)


            {
                MessageBox.Show("error");
            }



        }

        private void button_ConsultarFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                listView_Fornecedores.Items.Clear();

                using (Contexto db = new Contexto())
                {
                    Cursor.Current = Cursors.WaitCursor;
                    List<Fornecedores> lista = db.fornecedor.ToList();
                    foreach (Fornecedores f in lista)
                    {
                        ListViewItem item = new ListViewItem(f.id.ToString());
                        item.SubItems.Add(f.nome);
                        item.SubItems.Add(f.telefone);
                        item.SubItems.Add(f.cnpj);
                        listView_Fornecedores.Items.Add(item);
                    }
                }
                Cursor.Current = Cursors.Default;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            try
            {


                Contexto contexto = new Contexto();
                int id = int.Parse(textBox_deletar.Text);
                Fornecedores f = contexto.fornecedor.Find(id);


                using (Contexto db = new Contexto())
                    if (MessageBox.Show("Você Realmente deseja deletar?", "Delete Clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        contexto.fornecedor.Remove(f);
                        contexto.SaveChanges();
                    }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_editarFornecedores_Click(object sender, EventArgs e)
        {
            int i;
            i = listView_Fornecedores.SelectedItems[0].Index;
            textBox_NomeFornecedor.Text = listView_Fornecedores.Items[i].SubItems[1].Text.ToString();
            textBox_cnpjFornecedor.Text = listView_Fornecedores.Items[i].SubItems[2].Text.ToString();
            textBox_telefoneFornecedor.Text = listView_Fornecedores.Items[i].SubItems[3].Text.ToString();
        }
    }
}
