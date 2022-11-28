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
    public partial class CadastrarNotas : Form
    {
        public CadastrarNotas()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaInicial frm = new TelaInicial();
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_fornecedores frm = new Form_fornecedores();
            frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            cadastroClientes frm = new cadastroClientes();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cadastroDeProdutos frm = new cadastroDeProdutos();
            frm.Show();
        }

        private void button_GravarNotas_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();

                Notas n = new Notas();

                n.infoNota = (textBox_infoNota.Text);
                n.Nfnumero = int.Parse(textBox_NfNumero.Text);
                n.total = int.Parse(textBox_total.Text);
                contexto.notas.Add(n);
                contexto.SaveChanges();
                MessageBox.Show("Nota inserido com sucesso");

            }
            catch (Exception ex)


            {
                MessageBox.Show("error");
            }

        }

        private void button_ConsultarNotas_Click(object sender, EventArgs e)
        {
            try
            {
                listView_Notas.Items.Clear();

                using (Contexto db = new Contexto())
                {
                    Cursor.Current = Cursors.WaitCursor;
                    List<Notas> lista = db.notas.ToList();
                    foreach (Notas n in lista)
                    {
                        ListViewItem item = new ListViewItem(n.id.ToString());
                        item.SubItems.Add(n.infoNota);
                        item.SubItems.Add(n.Nfnumero.ToString());
                        item.SubItems.Add(n.total.ToString());

                        listView_Notas.Items.Add(item);
                    }
                }
                Cursor.Current = Cursors.Default;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_DeletarNotas_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();
                int id = int.Parse(textBox_deletarNota.Text);
                Notas n = contexto.notas.Find(id);
                if (MessageBox.Show("Você Realmente deseja deletar?", "Delete Nota", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    contexto.notas.Remove(n);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_editarNotas_Click(object sender, EventArgs e)
        {
            int i;
            i = listView_Notas.SelectedItems[0].Index;
            textBox_infoNota.Text = listView_Notas.Items[i].SubItems[1].Text.ToString();
            textBox_NfNumero.Text = listView_Notas.Items[i].SubItems[2].Text.ToString();
            textBox_total.Text = listView_Notas.Items[i].SubItems[3].Text.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_updateNota.Text);

                Contexto contexto = new Contexto();
                Notas n = contexto.notas.Find(id);
                n.infoNota = textBox_infoNota.Text;
                n.Nfnumero = int.Parse(textBox_NfNumero.Text);
                n.total = int.Parse(textBox_total.Text);

                if (MessageBox.Show("Você Realmente deseja alterar?", "Alterar Nota", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    contexto.notas.Update(n);
                    contexto.SaveChanges();
                    MessageBox.Show("Nota alterado com sucesso");
                }
                listView_Notas.Items.Clear();
            }
            catch (Exception ex)


            {
                MessageBox.Show("error");
            }
        }

        private void button_filtrarNota_Click(object sender, EventArgs e)
        {
            try
            {

                Contexto contexto = new Contexto();
                int id = int.Parse(textBox_filtrarNota.Text);
                Notas n = contexto.notas.Find(id);


                using (Contexto db = new Contexto())
                    if (MessageBox.Show("Você Realmente deseja Realizar o filtro?", "Filtrando Notas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        listView_Notas.Items.Clear();
                        ListViewItem item = new ListViewItem(n.id.ToString());
                        item.SubItems.Add(n.infoNota);
                        item.SubItems.Add(n.Nfnumero.ToString());
                        item.SubItems.Add(n.total.ToString());
                        listView_Notas.Items.Add(item);
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
