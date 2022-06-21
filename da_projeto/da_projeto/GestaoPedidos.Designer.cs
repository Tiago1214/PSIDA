namespace da_projeto
{
    partial class GestaoPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoPedidos));
            this.listBoxTrabalhador = new System.Windows.Forms.ListBox();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.listBoxPedido = new System.Windows.Forms.ListBox();
            this.listBoxItemMenu = new System.Windows.Forms.ListBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.listBoxItemSelecionado = new System.Windows.Forms.ListBox();
            this.btnCriarPedido = new System.Windows.Forms.Button();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.gpPedidos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gpPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTrabalhador
            // 
            this.listBoxTrabalhador.FormattingEnabled = true;
            this.listBoxTrabalhador.Location = new System.Drawing.Point(7, 76);
            this.listBoxTrabalhador.Name = "listBoxTrabalhador";
            this.listBoxTrabalhador.Size = new System.Drawing.Size(120, 160);
            this.listBoxTrabalhador.TabIndex = 6;
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.Location = new System.Drawing.Point(9, 281);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(120, 160);
            this.listBoxCliente.TabIndex = 7;
            // 
            // listBoxPedido
            // 
            this.listBoxPedido.FormattingEnabled = true;
            this.listBoxPedido.Location = new System.Drawing.Point(371, 204);
            this.listBoxPedido.Name = "listBoxPedido";
            this.listBoxPedido.Size = new System.Drawing.Size(120, 160);
            this.listBoxPedido.TabIndex = 9;
            this.listBoxPedido.SelectedIndexChanged += new System.EventHandler(this.listBoxPedido_SelectedIndexChanged);
            // 
            // listBoxItemMenu
            // 
            this.listBoxItemMenu.FormattingEnabled = true;
            this.listBoxItemMenu.Location = new System.Drawing.Point(535, 52);
            this.listBoxItemMenu.Name = "listBoxItemMenu";
            this.listBoxItemMenu.Size = new System.Drawing.Size(120, 160);
            this.listBoxItemMenu.TabIndex = 10;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(671, 252);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 11;
            // 
            // listBoxItemSelecionado
            // 
            this.listBoxItemSelecionado.FormattingEnabled = true;
            this.listBoxItemSelecionado.Location = new System.Drawing.Point(535, 373);
            this.listBoxItemSelecionado.Name = "listBoxItemSelecionado";
            this.listBoxItemSelecionado.Size = new System.Drawing.Size(120, 160);
            this.listBoxItemSelecionado.TabIndex = 12;
            // 
            // btnCriarPedido
            // 
            this.btnCriarPedido.BackgroundImage = global::da_projeto.Properties.Resources.Add_icon__1_;
            this.btnCriarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCriarPedido.Location = new System.Drawing.Point(158, 99);
            this.btnCriarPedido.Name = "btnCriarPedido";
            this.btnCriarPedido.Size = new System.Drawing.Size(123, 88);
            this.btnCriarPedido.TabIndex = 13;
            this.btnCriarPedido.Text = "Criar Pedido";
            this.btnCriarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCriarPedido.UseVisualStyleBackColor = true;
            this.btnCriarPedido.Click += new System.EventHandler(this.btnCriarPedido_Click);
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.BackgroundImage = global::da_projeto.Properties.Resources.Pencil_icon;
            this.btnEditarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarPedido.Location = new System.Drawing.Point(815, 212);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(123, 88);
            this.btnEditarPedido.TabIndex = 14;
            this.btnEditarPedido.Text = "Atualizar Pedido";
            this.btnEditarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            // 
            // gpPedidos
            // 
            this.gpPedidos.Controls.Add(this.label3);
            this.gpPedidos.Controls.Add(this.label2);
            this.gpPedidos.Controls.Add(this.listBoxTrabalhador);
            this.gpPedidos.Controls.Add(this.btnCriarPedido);
            this.gpPedidos.Controls.Add(this.listBoxCliente);
            this.gpPedidos.Location = new System.Drawing.Point(12, 161);
            this.gpPedidos.Name = "gpPedidos";
            this.gpPedidos.Size = new System.Drawing.Size(284, 452);
            this.gpPedidos.TabIndex = 17;
            this.gpPedidos.TabStop = false;
            this.gpPedidos.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Selecionar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selecionar Trabalhador";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(12, 132);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(281, 23);
            this.btnRegistar.TabIndex = 15;
            this.btnRegistar.Text = "Registar Novo Pedido";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Selecionar Restaurante";
            // 
            // listBoxRestaurantes
            // 
            this.listBoxRestaurantes.FormattingEnabled = true;
            this.listBoxRestaurantes.Location = new System.Drawing.Point(15, 29);
            this.listBoxRestaurantes.Name = "listBoxRestaurantes";
            this.listBoxRestaurantes.Size = new System.Drawing.Size(327, 95);
            this.listBoxRestaurantes.TabIndex = 20;
            this.listBoxRestaurantes.SelectedIndexChanged += new System.EventHandler(this.listBoxRestaurantes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Adicionar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestaoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1022, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRestaurantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.gpPedidos);
            this.Controls.Add(this.btnEditarPedido);
            this.Controls.Add(this.listBoxItemSelecionado);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.listBoxItemMenu);
            this.Controls.Add(this.listBoxPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestaoPedidos";
            this.Text = "GestaoPedidos";
            this.Load += new System.EventHandler(this.GestaoPedidos_Load);
            this.gpPedidos.ResumeLayout(false);
            this.gpPedidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTrabalhador;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.ListBox listBoxPedido;
        private System.Windows.Forms.ListBox listBoxItemMenu;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ListBox listBoxItemSelecionado;
        private System.Windows.Forms.Button btnCriarPedido;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.GroupBox gpPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRestaurantes;
        private System.Windows.Forms.Button button1;
    }
}