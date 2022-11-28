namespace MiniErp2._0
{
    partial class CadastrarNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ConsultarNotas = new System.Windows.Forms.Button();
            this.button_GravarNotas = new System.Windows.Forms.Button();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_deletarNota = new System.Windows.Forms.TextBox();
            this.textBox_NfNumero = new System.Windows.Forms.TextBox();
            this.NF = new System.Windows.Forms.Label();
            this.textBox_infoNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Notas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button_DeletarNotas = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.textBox_updateNota = new System.Windows.Forms.TextBox();
            this.button_editarNotas = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_filtrarNota = new System.Windows.Forms.TextBox();
            this.button_filtrarNota = new System.Windows.Forms.Button();
            this.button_gerarNota = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ConsultarNotas
            // 
            this.button_ConsultarNotas.BackColor = System.Drawing.Color.Lavender;
            this.button_ConsultarNotas.Location = new System.Drawing.Point(105, 213);
            this.button_ConsultarNotas.Name = "button_ConsultarNotas";
            this.button_ConsultarNotas.Size = new System.Drawing.Size(75, 23);
            this.button_ConsultarNotas.TabIndex = 24;
            this.button_ConsultarNotas.Text = "Consultar";
            this.button_ConsultarNotas.UseVisualStyleBackColor = false;
            this.button_ConsultarNotas.Click += new System.EventHandler(this.button_ConsultarNotas_Click);
            // 
            // button_GravarNotas
            // 
            this.button_GravarNotas.BackColor = System.Drawing.Color.Lavender;
            this.button_GravarNotas.Location = new System.Drawing.Point(24, 213);
            this.button_GravarNotas.Name = "button_GravarNotas";
            this.button_GravarNotas.Size = new System.Drawing.Size(75, 23);
            this.button_GravarNotas.TabIndex = 23;
            this.button_GravarNotas.Text = "Gravar";
            this.button_GravarNotas.UseVisualStyleBackColor = false;
            this.button_GravarNotas.Click += new System.EventHandler(this.button_GravarNotas_Click);
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(24, 172);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.PlaceholderText = "Digite o id da Nota";
            this.textBox_total.Size = new System.Drawing.Size(205, 23);
            this.textBox_total.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total";
            // 
            // textBox_deletarNota
            // 
            this.textBox_deletarNota.Location = new System.Drawing.Point(235, 210);
            this.textBox_deletarNota.Name = "textBox_deletarNota";
            this.textBox_deletarNota.PlaceholderText = "digite o id da nota";
            this.textBox_deletarNota.Size = new System.Drawing.Size(149, 23);
            this.textBox_deletarNota.TabIndex = 19;
            // 
            // textBox_NfNumero
            // 
            this.textBox_NfNumero.Location = new System.Drawing.Point(24, 128);
            this.textBox_NfNumero.Name = "textBox_NfNumero";
            this.textBox_NfNumero.PlaceholderText = "Digite o CPF";
            this.textBox_NfNumero.Size = new System.Drawing.Size(205, 23);
            this.textBox_NfNumero.TabIndex = 17;
            // 
            // NF
            // 
            this.NF.AutoSize = true;
            this.NF.Location = new System.Drawing.Point(24, 110);
            this.NF.Name = "NF";
            this.NF.Size = new System.Drawing.Size(69, 15);
            this.NF.TabIndex = 16;
            this.NF.Text = "NF Numero";
            // 
            // textBox_infoNota
            // 
            this.textBox_infoNota.Location = new System.Drawing.Point(24, 84);
            this.textBox_infoNota.Name = "textBox_infoNota";
            this.textBox_infoNota.PlaceholderText = "Digite as informações da nota Fiscal";
            this.textBox_infoNota.Size = new System.Drawing.Size(205, 23);
            this.textBox_infoNota.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Informação da nota";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem1.Text = "Menu Inicial";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 20);
            this.toolStripMenuItem2.Text = "Cadastro de Fornedores";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 20);
            this.toolStripMenuItem3.Text = "Cadastro de Produtos";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItem4.Text = "Cadastro de Clientes";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem5.Text = "Sair";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // listView_Notas
            // 
            this.listView_Notas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Notas.FullRowSelect = true;
            this.listView_Notas.GridLines = true;
            this.listView_Notas.Location = new System.Drawing.Point(235, 84);
            this.listView_Notas.MultiSelect = false;
            this.listView_Notas.Name = "listView_Notas";
            this.listView_Notas.Size = new System.Drawing.Size(437, 120);
            this.listView_Notas.TabIndex = 25;
            this.listView_Notas.UseCompatibleStateImageBehavior = false;
            this.listView_Notas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id nota";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Informação da Nota";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NF";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 50;
            // 
            // button_DeletarNotas
            // 
            this.button_DeletarNotas.Location = new System.Drawing.Point(235, 239);
            this.button_DeletarNotas.Name = "button_DeletarNotas";
            this.button_DeletarNotas.Size = new System.Drawing.Size(66, 22);
            this.button_DeletarNotas.TabIndex = 26;
            this.button_DeletarNotas.Text = "Deletar";
            this.button_DeletarNotas.UseVisualStyleBackColor = true;
            this.button_DeletarNotas.Click += new System.EventHandler(this.button_DeletarNotas_Click);
            // 
            // textBox_updateNota
            // 
            this.textBox_updateNota.Location = new System.Drawing.Point(412, 210);
            this.textBox_updateNota.Name = "textBox_updateNota";
            this.textBox_updateNota.PlaceholderText = "digite o id da nota";
            this.textBox_updateNota.Size = new System.Drawing.Size(149, 23);
            this.textBox_updateNota.TabIndex = 27;
            // 
            // button_editarNotas
            // 
            this.button_editarNotas.Location = new System.Drawing.Point(412, 239);
            this.button_editarNotas.Name = "button_editarNotas";
            this.button_editarNotas.Size = new System.Drawing.Size(66, 22);
            this.button_editarNotas.TabIndex = 28;
            this.button_editarNotas.Text = "Editar";
            this.button_editarNotas.UseVisualStyleBackColor = true;
            this.button_editarNotas.Click += new System.EventHandler(this.button_editarNotas_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(484, 239);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(66, 22);
            this.button_update.TabIndex = 29;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_filtrarNota
            // 
            this.textBox_filtrarNota.Location = new System.Drawing.Point(678, 84);
            this.textBox_filtrarNota.Name = "textBox_filtrarNota";
            this.textBox_filtrarNota.PlaceholderText = "digite o id da nota";
            this.textBox_filtrarNota.Size = new System.Drawing.Size(149, 23);
            this.textBox_filtrarNota.TabIndex = 30;
            // 
            // button_filtrarNota
            // 
            this.button_filtrarNota.Location = new System.Drawing.Point(678, 113);
            this.button_filtrarNota.Name = "button_filtrarNota";
            this.button_filtrarNota.Size = new System.Drawing.Size(66, 22);
            this.button_filtrarNota.TabIndex = 31;
            this.button_filtrarNota.Text = "Filtrar";
            this.button_filtrarNota.UseVisualStyleBackColor = true;
            this.button_filtrarNota.Click += new System.EventHandler(this.button_filtrarNota_Click);
            // 
            // button_gerarNota
            // 
            this.button_gerarNota.Location = new System.Drawing.Point(678, 181);
            this.button_gerarNota.Name = "button_gerarNota";
            this.button_gerarNota.Size = new System.Drawing.Size(257, 23);
            this.button_gerarNota.TabIndex = 32;
            this.button_gerarNota.Text = "Gerar Nota";
            this.button_gerarNota.UseVisualStyleBackColor = true;
            this.button_gerarNota.Click += new System.EventHandler(this.button_gerarNota_Click);
            // 
            // CadastrarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.button_gerarNota);
            this.Controls.Add(this.button_filtrarNota);
            this.Controls.Add(this.textBox_filtrarNota);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_editarNotas);
            this.Controls.Add(this.textBox_updateNota);
            this.Controls.Add(this.button_DeletarNotas);
            this.Controls.Add(this.listView_Notas);
            this.Controls.Add(this.button_ConsultarNotas);
            this.Controls.Add(this.button_GravarNotas);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_deletarNota);
            this.Controls.Add(this.textBox_NfNumero);
            this.Controls.Add(this.NF);
            this.Controls.Add(this.textBox_infoNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CadastrarNotas";
            this.Text = "CadastrarNotas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_ConsultarNotas;
        private Button button_GravarNotas;
        private TextBox textBox_total;
        private Label label4;
        private TextBox textBox_deletarNota;
        private TextBox textBox_NfNumero;
        private Label NF;
        private TextBox textBox_infoNota;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ListView listView_Notas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button_DeletarNotas;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox textBox_updateNota;
        private Button button_editarNotas;
        private Button button_update;
        private TextBox textBox_filtrarNota;
        private Button button_filtrarNota;
        private Button button_gerarNota;
    }
}