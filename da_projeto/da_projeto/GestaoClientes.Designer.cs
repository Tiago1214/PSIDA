namespace da_projeto
{
    partial class GestaoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoClientes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarbuton = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.lbclientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.masktxttele = new System.Windows.Forms.MaskedTextBox();
            this.masktxtnif = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarbutton,
            this.apagarbutton,
            this.alterarbuton,
            this.guardarbutton,
            this.voltarbutton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registarbutton
            // 
            this.registarbutton.Image = global::da_projeto.Properties.Resources.Add_icon__1_;
            this.registarbutton.Name = "registarbutton";
            this.registarbutton.Size = new System.Drawing.Size(81, 24);
            this.registarbutton.Text = "Registar";
            this.registarbutton.Click += new System.EventHandler(this.registarToolStripMenuItem_Click);
            // 
            // apagarbutton
            // 
            this.apagarbutton.Image = global::da_projeto.Properties.Resources.Messaging_Trash_icon;
            this.apagarbutton.Name = "apagarbutton";
            this.apagarbutton.Size = new System.Drawing.Size(77, 24);
            this.apagarbutton.Text = "Apagar";
            this.apagarbutton.Click += new System.EventHandler(this.apagarbutton_Click);
            // 
            // alterarbuton
            // 
            this.alterarbuton.Image = global::da_projeto.Properties.Resources.Pencil_icon;
            this.alterarbuton.Name = "alterarbuton";
            this.alterarbuton.Size = new System.Drawing.Size(74, 24);
            this.alterarbuton.Text = "Alterar";
            this.alterarbuton.Click += new System.EventHandler(this.alterarbuton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Image = global::da_projeto.Properties.Resources.Save_icon;
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(81, 24);
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // voltarbutton
            // 
            this.voltarbutton.Image = global::da_projeto.Properties.Resources.Back_2_2_icon;
            this.voltarbutton.Name = "voltarbutton";
            this.voltarbutton.Size = new System.Drawing.Size(69, 24);
            this.voltarbutton.Text = "Voltar";
            this.voltarbutton.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // lbclientes
            // 
            this.lbclientes.FormattingEnabled = true;
            this.lbclientes.Location = new System.Drawing.Point(9, 211);
            this.lbclientes.Margin = new System.Windows.Forms.Padding(2);
            this.lbclientes.Name = "lbclientes";
            this.lbclientes.Size = new System.Drawing.Size(568, 134);
            this.lbclientes.TabIndex = 1;
            this.lbclientes.SelectedIndexChanged += new System.EventHandler(this.lbclientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(112, 65);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(224, 20);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Morada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telemovel";
            // 
            // masktxttele
            // 
            this.masktxttele.Location = new System.Drawing.Point(112, 126);
            this.masktxttele.Margin = new System.Windows.Forms.Padding(2);
            this.masktxttele.Mask = "000000000";
            this.masktxttele.Name = "masktxttele";
            this.masktxttele.Size = new System.Drawing.Size(66, 20);
            this.masktxttele.TabIndex = 7;
            // 
            // masktxtnif
            // 
            this.masktxtnif.Location = new System.Drawing.Point(112, 155);
            this.masktxtnif.Margin = new System.Windows.Forms.Padding(2);
            this.masktxtnif.Mask = "000000000";
            this.masktxtnif.Name = "masktxtnif";
            this.masktxtnif.Size = new System.Drawing.Size(66, 20);
            this.masktxtnif.TabIndex = 9;
            this.masktxtnif.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número Contribuinte";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 95);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // GestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.masktxtnif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.masktxttele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbclientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestaoClientes";
            this.Text = "GestaoClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoClientes_FormClosing);
            this.Load += new System.EventHandler(this.GestaoClientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registarbutton;
        private System.Windows.Forms.ToolStripMenuItem apagarbutton;
        private System.Windows.Forms.ToolStripMenuItem alterarbuton;
        private System.Windows.Forms.ToolStripMenuItem guardarbutton;
        private System.Windows.Forms.ListBox lbclientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masktxttele;
        private System.Windows.Forms.MaskedTextBox masktxtnif;
        private System.Windows.Forms.Label label4;


        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbmorada;





        private System.Windows.Forms.ToolStripMenuItem voltarbutton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}