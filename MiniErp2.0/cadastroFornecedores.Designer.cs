﻿namespace MiniErp2._0
{
    partial class Form_fornecedores
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
            this.button_ConsultarFornecedores = new System.Windows.Forms.Button();
            this.button_GravarFornecedor = new System.Windows.Forms.Button();
            this.textBox_telefoneFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cnpjFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NomeFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Fornecedores = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ConsultarFornecedores
            // 
            this.button_ConsultarFornecedores.BackColor = System.Drawing.Color.Lavender;
            this.button_ConsultarFornecedores.Location = new System.Drawing.Point(104, 237);
            this.button_ConsultarFornecedores.Name = "button_ConsultarFornecedores";
            this.button_ConsultarFornecedores.Size = new System.Drawing.Size(75, 23);
            this.button_ConsultarFornecedores.TabIndex = 24;
            this.button_ConsultarFornecedores.Text = "Consultar";
            this.button_ConsultarFornecedores.UseVisualStyleBackColor = false;
            this.button_ConsultarFornecedores.Click += new System.EventHandler(this.button_ConsultarFornecedores_Click);
            // 
            // button_GravarFornecedor
            // 
            this.button_GravarFornecedor.BackColor = System.Drawing.Color.Lavender;
            this.button_GravarFornecedor.Location = new System.Drawing.Point(23, 237);
            this.button_GravarFornecedor.Name = "button_GravarFornecedor";
            this.button_GravarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_GravarFornecedor.TabIndex = 23;
            this.button_GravarFornecedor.Text = "Gravar";
            this.button_GravarFornecedor.UseVisualStyleBackColor = false;
            this.button_GravarFornecedor.Click += new System.EventHandler(this.button_GravarFornecedor_Click);
            // 
            // textBox_telefoneFornecedor
            // 
            this.textBox_telefoneFornecedor.Location = new System.Drawing.Point(23, 193);
            this.textBox_telefoneFornecedor.Name = "textBox_telefoneFornecedor";
            this.textBox_telefoneFornecedor.PlaceholderText = "digite o telefone";
            this.textBox_telefoneFornecedor.Size = new System.Drawing.Size(149, 23);
            this.textBox_telefoneFornecedor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefone";
            // 
            // textBox_cnpjFornecedor
            // 
            this.textBox_cnpjFornecedor.Location = new System.Drawing.Point(23, 149);
            this.textBox_cnpjFornecedor.Name = "textBox_cnpjFornecedor";
            this.textBox_cnpjFornecedor.PlaceholderText = "Digite o CNPJ";
            this.textBox_cnpjFornecedor.Size = new System.Drawing.Size(149, 23);
            this.textBox_cnpjFornecedor.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "CNPJ";
            // 
            // textBox_NomeFornecedor
            // 
            this.textBox_NomeFornecedor.Location = new System.Drawing.Point(23, 105);
            this.textBox_NomeFornecedor.Name = "textBox_NomeFornecedor";
            this.textBox_NomeFornecedor.PlaceholderText = "Digite o nome do Fornecedor";
            this.textBox_NomeFornecedor.Size = new System.Drawing.Size(149, 23);
            this.textBox_NomeFornecedor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItem2.Text = "Cadastro de Clientes";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 20);
            this.toolStripMenuItem3.Text = "Cadastro de Produtos";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 20);
            this.toolStripMenuItem4.Text = "Cadastro de Notas";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem5.Text = "Sair";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // listView_Fornecedores
            // 
            this.listView_Fornecedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Fornecedores.FullRowSelect = true;
            this.listView_Fornecedores.GridLines = true;
            this.listView_Fornecedores.Location = new System.Drawing.Point(192, 105);
            this.listView_Fornecedores.MultiSelect = false;
            this.listView_Fornecedores.Name = "listView_Fornecedores";
            this.listView_Fornecedores.Size = new System.Drawing.Size(360, 155);
            this.listView_Fornecedores.TabIndex = 25;
            this.listView_Fornecedores.UseCompatibleStateImageBehavior = false;
            this.listView_Fornecedores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id Fornecedor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CNPJ";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.Width = 100;
            // 
            // Form_fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_Fornecedores);
            this.Controls.Add(this.button_ConsultarFornecedores);
            this.Controls.Add(this.button_GravarFornecedor);
            this.Controls.Add(this.textBox_telefoneFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cnpjFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_fornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_ConsultarFornecedores;
        private Button button_GravarFornecedor;
        private TextBox textBox_telefoneFornecedor;
        private Label label3;
        private TextBox textBox_cnpjFornecedor;
        private Label label2;
        private TextBox textBox_NomeFornecedor;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ListView listView_Fornecedores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}