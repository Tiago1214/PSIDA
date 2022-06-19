namespace da_projeto
{
    partial class GestaoMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarbuton = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuRestaurante = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAtivo = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngridientes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
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
            this.cancelarbutton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(770, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registarbutton
            // 
            this.registarbutton.Image = global::da_projeto.Properties.Resources.Add_icon__1_;
            this.registarbutton.Name = "registarbutton";
            this.registarbutton.Size = new System.Drawing.Size(81, 24);
            this.registarbutton.Text = "Registar";
            this.registarbutton.Click += new System.EventHandler(this.registarbutton_Click);
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
            // 
            // guardarbutton
            // 
            this.guardarbutton.Image = global::da_projeto.Properties.Resources.Save_icon;
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(81, 24);
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Image = global::da_projeto.Properties.Resources.Back_2_2_icon;
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(69, 24);
            this.cancelarbutton.Text = "Voltar";
            this.cancelarbutton.Click += new System.EventHandler(this.voltarbutton_Click);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(253, 19);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(234, 368);
            this.listBoxMenu.TabIndex = 3;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.Location = new System.Drawing.Point(514, 57);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(224, 368);
            this.listBoxCategorias.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de Categorias";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuRestaurante);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxAtivo);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIngridientes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCarregarFoto);
            this.groupBox1.Controls.Add(this.pictureBoxImagem);
            this.groupBox1.Controls.Add(this.txtNomeItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBoxMenu);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 401);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items Menu";
            // 
            // btnMenuRestaurante
            // 
            this.btnMenuRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRestaurante.Location = new System.Drawing.Point(9, 20);
            this.btnMenuRestaurante.Name = "btnMenuRestaurante";
            this.btnMenuRestaurante.Size = new System.Drawing.Size(238, 61);
            this.btnMenuRestaurante.TabIndex = 18;
            this.btnMenuRestaurante.Text = "Ver Menu de cada Restaurante";
            this.btnMenuRestaurante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuRestaurante.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(73, 297);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(174, 21);
            this.comboBoxCategoria.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ativo:";
            // 
            // comboBoxAtivo
            // 
            this.comboBoxAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAtivo.FormattingEnabled = true;
            this.comboBoxAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboBoxAtivo.Location = new System.Drawing.Point(73, 347);
            this.comboBoxAtivo.Name = "comboBoxAtivo";
            this.comboBoxAtivo.Size = new System.Drawing.Size(174, 21);
            this.comboBoxAtivo.TabIndex = 14;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(73, 251);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(174, 20);
            this.txtPreco.TabIndex = 13;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preço:";
            // 
            // txtIngridientes
            // 
            this.txtIngridientes.Location = new System.Drawing.Point(73, 212);
            this.txtIngridientes.Name = "txtIngridientes";
            this.txtIngridientes.Size = new System.Drawing.Size(174, 20);
            this.txtIngridientes.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingridientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selecionar Fotografia:";
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCarregarFoto.Image = global::da_projeto.Properties.Resources._211608_folder_icon;
            this.btnCarregarFoto.Location = new System.Drawing.Point(6, 149);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(48, 35);
            this.btnCarregarFoto.TabIndex = 8;
            this.btnCarregarFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarregarFoto.UseVisualStyleBackColor = false;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(118, 130);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(64, 54);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagem.TabIndex = 7;
            this.pictureBoxImagem.TabStop = false;
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(73, 87);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(174, 20);
            this.txtNomeItem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // GestaoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCategorias);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestaoMenu";
            this.Text = "GestaoMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoMenu_FormClosing);
            this.Load += new System.EventHandler(this.GestaoMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registarbutton;
        private System.Windows.Forms.ToolStripMenuItem apagarbutton;
        private System.Windows.Forms.ToolStripMenuItem alterarbuton;
        private System.Windows.Forms.ToolStripMenuItem guardarbutton;
        private System.Windows.Forms.ToolStripMenuItem cancelarbutton;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAtivo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIngridientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMenuRestaurante;
    }
}