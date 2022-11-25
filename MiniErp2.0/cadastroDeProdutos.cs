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
    public partial class cadastroDeProdutos : Form
    {
        public cadastroDeProdutos()
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

        private void button_GravarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();

                Produtos p = new Produtos();

                p.quantidade = int.Parse(textBox_quantidadeProduto.Text);
                p.preco = int.Parse(textBox_prcoProduto.Text);
                p.nome = textBox_NomeProduto.Text;




                contexto.produtos.Add(p);
                contexto.SaveChanges();
                MessageBox.Show("Produto inserido com sucesso");

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
                listView_Produtos.Items.Clear();

                using (Contexto db = new Contexto())
                {
                    Cursor.Current = Cursors.WaitCursor;
                    List<Produtos> lista = db.produtos.ToList();
                    foreach (Produtos p in lista)
                    {
                        ListViewItem item = new ListViewItem(p.id.ToString());
                        item.SubItems.Add(p.nome);
                        item.SubItems.Add(p.quantidade.ToString());
                        item.SubItems.Add(p.preco.ToString());
                        listView_Produtos.Items.Add(item);
                    }
                }
                Cursor.Current = Cursors.Default;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
