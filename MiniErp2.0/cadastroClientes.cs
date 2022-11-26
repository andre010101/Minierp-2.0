using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private void button_GravarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();

                Clientes c = new Clientes();

                c.cpf = textBox_cpfCliente.Text;
                c.telefone = textBox_telefoneCliente.Text;
                c.nome = textBox_NomeCliente.Text;

                contexto.clientes.Add(c);
                contexto.SaveChanges();
                MessageBox.Show("Cliente inserida com sucesso");

            }
            catch (Exception ex)


            {
                MessageBox.Show("error");
            }

        }

        private void button_ConsultarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                listView_Clientes.Items.Clear();

                using (Contexto db = new Contexto())
                {
                    Cursor.Current = Cursors.WaitCursor;
                    List<Clientes> lista = db.clientes.ToList();
                    foreach (Clientes c in lista)
                    {
                        ListViewItem item = new ListViewItem(c.id.ToString());
                        item.SubItems.Add(c.nome);
                        item.SubItems.Add(c.telefone);
                        item.SubItems.Add(c.cpf);
                        listView_Clientes.Items.Add(item);
                    }
                }
                Cursor.Current = Cursors.Default;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void listView_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (Contexto db = new Contexto())
            //    if (MessageBox.Show("Você Realmente deseja deletar?", "Delete Clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        int id = Convert.ToInt32(listView_Clientes.Items[e.index].Index["id"].FormattedValue.ToString());




            //        MessageBox.Show("sucesso deletado");

            //    }
        }

        private void button_DeletarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();

                Clientes c = new Clientes();
                int id = int.Parse(textBox_deltarCliente.Text);
                 contexto.clientes.Find(id);
                //if (MessageBox.Show("Você Realmente deseja deletar?", "Delete Clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)

                //{
                    contexto.clientes.Remove(c);
                    contexto.SaveChanges();
                //}
               
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
