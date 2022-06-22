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
            this.btnCriarPedido = new System.Windows.Forms.Button();
            this.gpPedidos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.gbAtualizarPedido = new System.Windows.Forms.GroupBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.listBoxItemSelecionado = new System.Windows.Forms.ListBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.listBoxItemMenu = new System.Windows.Forms.ListBox();
            this.gpPagamentos = new System.Windows.Forms.GroupBox();
            this.labelfaltapagar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPedidosProc = new System.Windows.Forms.ListBox();
            this.listBoxMetodosPagamentos = new System.Windows.Forms.ListBox();
            this.listBoxPedidosConcluidos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExportartxt = new System.Windows.Forms.Button();
            this.gpPedidos.SuspendLayout();
            this.gbAtualizarPedido.SuspendLayout();
            this.gpPagamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.listBoxPedido.Location = new System.Drawing.Point(317, 234);
            this.listBoxPedido.Name = "listBoxPedido";
            this.listBoxPedido.Size = new System.Drawing.Size(120, 368);
            this.listBoxPedido.TabIndex = 9;
            this.listBoxPedido.SelectedIndexChanged += new System.EventHandler(this.listBoxPedido_SelectedIndexChanged);
            // 
            // btnCriarPedido
            // 
            this.btnCriarPedido.BackgroundImage = global::da_projeto.Properties.Resources.Add_icon__1_;
            this.btnCriarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCriarPedido.Location = new System.Drawing.Point(172, 190);
            this.btnCriarPedido.Name = "btnCriarPedido";
            this.btnCriarPedido.Size = new System.Drawing.Size(90, 79);
            this.btnCriarPedido.TabIndex = 13;
            this.btnCriarPedido.Text = "Criar Pedido";
            this.btnCriarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCriarPedido.UseVisualStyleBackColor = true;
            this.btnCriarPedido.Click += new System.EventHandler(this.btnCriarPedido_Click);
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
            this.gpPedidos.Size = new System.Drawing.Size(299, 452);
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
            // gbAtualizarPedido
            // 
            this.gbAtualizarPedido.Controls.Add(this.label10);
            this.gbAtualizarPedido.Controls.Add(this.label9);
            this.gbAtualizarPedido.Controls.Add(this.btnRemoverItem);
            this.gbAtualizarPedido.Controls.Add(this.btnAdicionarItem);
            this.gbAtualizarPedido.Controls.Add(this.btnEditarPedido);
            this.gbAtualizarPedido.Controls.Add(this.listBoxItemSelecionado);
            this.gbAtualizarPedido.Controls.Add(this.comboBoxEstado);
            this.gbAtualizarPedido.Controls.Add(this.listBoxItemMenu);
            this.gbAtualizarPedido.Location = new System.Drawing.Point(443, 56);
            this.gbAtualizarPedido.Name = "gbAtualizarPedido";
            this.gbAtualizarPedido.Size = new System.Drawing.Size(155, 557);
            this.gbAtualizarPedido.TabIndex = 21;
            this.gbAtualizarPedido.TabStop = false;
            this.gbAtualizarPedido.Text = "Itens Pedido";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(7, 534);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(120, 23);
            this.btnRemoverItem.TabIndex = 25;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(6, 318);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionarItem.TabIndex = 24;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.BackgroundImage = global::da_projeto.Properties.Resources.Pencil_icon;
            this.btnEditarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarPedido.Location = new System.Drawing.Point(20, 46);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(94, 71);
            this.btnEditarPedido.TabIndex = 23;
            this.btnEditarPedido.Text = "Atualizar Pedido";
            this.btnEditarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            this.btnEditarPedido.Click += new System.EventHandler(this.btnEditarPedido_Click);
            // 
            // listBoxItemSelecionado
            // 
            this.listBoxItemSelecionado.FormattingEnabled = true;
            this.listBoxItemSelecionado.Location = new System.Drawing.Point(6, 368);
            this.listBoxItemSelecionado.Name = "listBoxItemSelecionado";
            this.listBoxItemSelecionado.Size = new System.Drawing.Size(120, 160);
            this.listBoxItemSelecionado.TabIndex = 22;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 21;
            // 
            // listBoxItemMenu
            // 
            this.listBoxItemMenu.FormattingEnabled = true;
            this.listBoxItemMenu.Location = new System.Drawing.Point(6, 145);
            this.listBoxItemMenu.Name = "listBoxItemMenu";
            this.listBoxItemMenu.Size = new System.Drawing.Size(120, 160);
            this.listBoxItemMenu.TabIndex = 20;
            // 
            // gpPagamentos
            // 
            this.gpPagamentos.Controls.Add(this.label8);
            this.gpPagamentos.Controls.Add(this.label7);
            this.gpPagamentos.Controls.Add(this.labelfaltapagar);
            this.gpPagamentos.Controls.Add(this.label5);
            this.gpPagamentos.Controls.Add(this.numericUpDown1);
            this.gpPagamentos.Controls.Add(this.btnPagamento);
            this.gpPagamentos.Controls.Add(this.label4);
            this.gpPagamentos.Controls.Add(this.listBoxPedidosProc);
            this.gpPagamentos.Controls.Add(this.listBoxMetodosPagamentos);
            this.gpPagamentos.Location = new System.Drawing.Point(604, 56);
            this.gpPagamentos.Name = "gpPagamentos";
            this.gpPagamentos.Size = new System.Drawing.Size(406, 405);
            this.gpPagamentos.TabIndex = 22;
            this.gpPagamentos.TabStop = false;
            this.gpPagamentos.Text = "Pagar Pedido";
            // 
            // labelfaltapagar
            // 
            this.labelfaltapagar.AutoSize = true;
            this.labelfaltapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfaltapagar.Location = new System.Drawing.Point(107, 306);
            this.labelfaltapagar.Name = "labelfaltapagar";
            this.labelfaltapagar.Size = new System.Drawing.Size(0, 20);
            this.labelfaltapagar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Falta Pagar:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 285);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(10, 337);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(269, 57);
            this.btnPagamento.TabIndex = 4;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pagar:";
            // 
            // listBoxPedidosProc
            // 
            this.listBoxPedidosProc.FormattingEnabled = true;
            this.listBoxPedidosProc.Location = new System.Drawing.Point(6, 46);
            this.listBoxPedidosProc.Name = "listBoxPedidosProc";
            this.listBoxPedidosProc.Size = new System.Drawing.Size(256, 95);
            this.listBoxPedidosProc.TabIndex = 1;
            this.listBoxPedidosProc.SelectedIndexChanged += new System.EventHandler(this.listBoxPedidosProc_SelectedIndexChanged);
            // 
            // listBoxMetodosPagamentos
            // 
            this.listBoxMetodosPagamentos.FormattingEnabled = true;
            this.listBoxMetodosPagamentos.Location = new System.Drawing.Point(6, 166);
            this.listBoxMetodosPagamentos.Name = "listBoxMetodosPagamentos";
            this.listBoxMetodosPagamentos.Size = new System.Drawing.Size(256, 95);
            this.listBoxMetodosPagamentos.TabIndex = 0;
            // 
            // listBoxPedidosConcluidos
            // 
            this.listBoxPedidosConcluidos.FormattingEnabled = true;
            this.listBoxPedidosConcluidos.Location = new System.Drawing.Point(9, 36);
            this.listBoxPedidosConcluidos.Name = "listBoxPedidosConcluidos";
            this.listBoxPedidosConcluidos.Size = new System.Drawing.Size(204, 134);
            this.listBoxPedidosConcluidos.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportartxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.listBoxPedidosConcluidos);
            this.groupBox1.Location = new System.Drawing.Point(604, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 188);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pedidos Recebidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pedidos Em Processamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Métodos de Pagamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Items Menu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Items Menu Pedido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pedidos Conluídos";
            // 
            // btnExportartxt
            // 
            this.btnExportartxt.Location = new System.Drawing.Point(219, 71);
            this.btnExportartxt.Name = "btnExportartxt";
            this.btnExportartxt.Size = new System.Drawing.Size(93, 57);
            this.btnExportartxt.TabIndex = 26;
            this.btnExportartxt.Text = "Exportar Para txt";
            this.btnExportartxt.UseVisualStyleBackColor = true;
            this.btnExportartxt.Click += new System.EventHandler(this.btnExportartxt_Click);
            // 
            // GestaoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(951, 646);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpPagamentos);
            this.Controls.Add(this.gbAtualizarPedido);
            this.Controls.Add(this.listBoxRestaurantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.gpPedidos);
            this.Controls.Add(this.listBoxPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestaoPedidos";
            this.Text = "GestaoPedidos";
            this.Load += new System.EventHandler(this.GestaoPedidos_Load);
            this.gpPedidos.ResumeLayout(false);
            this.gpPedidos.PerformLayout();
            this.gbAtualizarPedido.ResumeLayout(false);
            this.gbAtualizarPedido.PerformLayout();
            this.gpPagamentos.ResumeLayout(false);
            this.gpPagamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTrabalhador;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.ListBox listBoxPedido;
        private System.Windows.Forms.Button btnCriarPedido;
        private System.Windows.Forms.GroupBox gpPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRestaurantes;
        private System.Windows.Forms.GroupBox gbAtualizarPedido;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.ListBox listBoxItemSelecionado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ListBox listBoxItemMenu;
        private System.Windows.Forms.GroupBox gpPagamentos;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.ListBox listBoxPedidosProc;
        private System.Windows.Forms.ListBox listBoxMetodosPagamentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Label labelfaltapagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxPedidosConcluidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportartxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
    }
}