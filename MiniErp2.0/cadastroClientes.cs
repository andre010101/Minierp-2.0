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
                c.nome = textBox_NomeCliente.Text;
                c.cpf = textBox_cpfCliente.Text;
                c.telefone = textBox_telefoneCliente.Text;
               

                contexto.clientes.Add(c);
                contexto.SaveChanges();
                MessageBox.Show("Cliente inserido com sucesso");

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
                        item.SubItems.Add(c.cpf);
                        item.SubItems.Add(c.telefone);
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
                int id = int.Parse(textBox_deltarCliente.Text);
                Clientes c = contexto.clientes.Find(id);


                using (Contexto db = new Contexto())
                    if (MessageBox.Show("Você Realmente deseja deletar?", "Delete Clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        contexto.clientes.Remove(c);
                        contexto.SaveChanges();
                    }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       

        private void button_Updat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_idup.Text);
                //Clientes c = new Clientes();
                Contexto contexto = new Contexto();
                Clientes c = contexto.clientes.Find(id);
                c.nome = textBox_NomeCliente.Text;
                c.telefone = textBox_telefoneCliente.Text;
                c.cpf = textBox_cpfCliente.Text;

                if (MessageBox.Show("Você Realmente deseja alterar?", "Alterar Clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    

                   
                    contexto.clientes.Update(c);
                    contexto.SaveChanges();
                    MessageBox.Show("Cliente alterado com sucesso");
                }
                listView_Clientes.Items.Clear();
            }
            catch (Exception ex)


            {
                MessageBox.Show("error");
            }

        }

        private void button_editar_Click_1(object sender, EventArgs e)
        {
            int i;
            i = listView_Clientes.SelectedItems[0].Index;
            textBox_NomeCliente.Text = listView_Clientes.Items[i].SubItems[1].Text.ToString();
            textBox_cpfCliente.Text = listView_Clientes.Items[i].SubItems[2].Text.ToString();
            textBox_telefoneCliente.Text = listView_Clientes.Items[i].SubItems[3].Text.ToString();
        }

        private void button_FiltarCliente_Click(object sender, EventArgs e)
        {
            try
            {


                Contexto contexto = new Contexto();
                int id = int.Parse(textBox_FiltrarClientes.Text);
                Clientes c = contexto.clientes.Find(id);


                using (Contexto db = new Contexto())
                    if (MessageBox.Show("Você Realmente deseja Realizar o filtro?", "Filtrando Clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        listView_Clientes.Items.Clear();
                        ListViewItem item = new ListViewItem(c.id.ToString());
                        item.SubItems.Add(c.nome);
                        item.SubItems.Add(c.cpf);
                        item.SubItems.Add(c.telefone);
                        listView_Clientes.Items.Add(item);
                    }
               





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
