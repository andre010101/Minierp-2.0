namespace MiniErp2._0
{
    partial class cadastroClientes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cpfCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_telefoneCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_idCliente = new System.Windows.Forms.TextBox();
            this.button_GravarClientes = new System.Windows.Forms.Button();
            this.button_ConsultarClientes = new System.Windows.Forms.Button();
            this.textBox_notasCliente = new System.Windows.Forms.TextBox();
            this.listView_Clientes = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem1.Text = "Menu Inicial";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
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
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 20);
            this.toolStripMenuItem4.Text = "Cadastro de Notas";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem5.Text = "Sair";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // textBox_NomeCliente
            // 
            this.textBox_NomeCliente.Location = new System.Drawing.Point(12, 76);
            this.textBox_NomeCliente.Name = "textBox_NomeCliente";
            this.textBox_NomeCliente.PlaceholderText = "Digite o nome do cliente";
            this.textBox_NomeCliente.Size = new System.Drawing.Size(149, 23);
            this.textBox_NomeCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // textBox_cpfCliente
            // 
            this.textBox_cpfCliente.Location = new System.Drawing.Point(12, 130);
            this.textBox_cpfCliente.Name = "textBox_cpfCliente";
            this.textBox_cpfCliente.PlaceholderText = "Digite o CPF";
            this.textBox_cpfCliente.Size = new System.Drawing.Size(149, 23);
            this.textBox_cpfCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // textBox_telefoneCliente
            // 
            this.textBox_telefoneCliente.Location = new System.Drawing.Point(12, 174);
            this.textBox_telefoneCliente.Name = "textBox_telefoneCliente";
            this.textBox_telefoneCliente.PlaceholderText = "digite o telefone";
            this.textBox_telefoneCliente.Size = new System.Drawing.Size(149, 23);
            this.textBox_telefoneCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Cliente";
            // 
            // textBox_idCliente
            // 
            this.textBox_idCliente.Location = new System.Drawing.Point(12, 218);
            this.textBox_idCliente.Name = "textBox_idCliente";
            this.textBox_idCliente.PlaceholderText = "Digite o id do cliente";
            this.textBox_idCliente.Size = new System.Drawing.Size(149, 23);
            this.textBox_idCliente.TabIndex = 9;
            // 
            // button_GravarClientes
            // 
            this.button_GravarClientes.BackColor = System.Drawing.Color.Lavender;
            this.button_GravarClientes.Location = new System.Drawing.Point(12, 274);
            this.button_GravarClientes.Name = "button_GravarClientes";
            this.button_GravarClientes.Size = new System.Drawing.Size(75, 23);
            this.button_GravarClientes.TabIndex = 11;
            this.button_GravarClientes.Text = "Gravar";
            this.button_GravarClientes.UseVisualStyleBackColor = false;
            this.button_GravarClientes.Click += new System.EventHandler(this.button_GravarClientes_Click);
            // 
            // button_ConsultarClientes
            // 
            this.button_ConsultarClientes.BackColor = System.Drawing.Color.Lavender;
            this.button_ConsultarClientes.Location = new System.Drawing.Point(93, 274);
            this.button_ConsultarClientes.Name = "button_ConsultarClientes";
            this.button_ConsultarClientes.Size = new System.Drawing.Size(75, 23);
            this.button_ConsultarClientes.TabIndex = 12;
            this.button_ConsultarClientes.Text = "Consultar";
            this.button_ConsultarClientes.UseVisualStyleBackColor = false;
            this.button_ConsultarClientes.Click += new System.EventHandler(this.button_ConsultarClientes_Click);
            // 
            // textBox_notasCliente
            // 
            this.textBox_notasCliente.Location = new System.Drawing.Point(218, 274);
            this.textBox_notasCliente.Name = "textBox_notasCliente";
            this.textBox_notasCliente.PlaceholderText = "Digite o id do cliente";
            this.textBox_notasCliente.Size = new System.Drawing.Size(149, 23);
            this.textBox_notasCliente.TabIndex = 13;
            // 
            // listView_Clientes
            // 
            this.listView_Clientes.Location = new System.Drawing.Point(207, 76);
            this.listView_Clientes.Name = "listView_Clientes";
            this.listView_Clientes.Size = new System.Drawing.Size(389, 165);
            this.listView_Clientes.TabIndex = 14;
            this.listView_Clientes.UseCompatibleStateImageBehavior = false;
            // 
            // cadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_Clientes);
            this.Controls.Add(this.textBox_notasCliente);
            this.Controls.Add(this.button_ConsultarClientes);
            this.Controls.Add(this.button_GravarClientes);
            this.Controls.Add(this.textBox_idCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_telefoneCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cpfCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "cadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private Label label1;
        private TextBox textBox_NomeCliente;
        private Label label2;
        private TextBox textBox_cpfCliente;
        private Label label3;
        private TextBox textBox_telefoneCliente;
        private Label label4;
        private TextBox textBox_idCliente;
        private Button button_GravarClientes;
        private Button button_ConsultarClientes;
        private TextBox textBox_notasCliente;
        private ListView listView_Clientes;
    }
}