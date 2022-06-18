namespace da_projeto
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnGestaoClientes = new System.Windows.Forms.Button();
            this.btnGestaoCadeia = new System.Windows.Forms.Button();
            this.btnGestaoRest = new System.Windows.Forms.Button();
            this.btnMenuRest = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestaoClientes
            // 
            this.btnGestaoClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnGestaoClientes.BackgroundImage = global::da_projeto.Properties.Resources._61816_business_buyers_clients_users_icon;
            this.btnGestaoClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoClientes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGestaoClientes.Location = new System.Drawing.Point(16, 288);
            this.btnGestaoClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestaoClientes.Name = "btnGestaoClientes";
            this.btnGestaoClientes.Size = new System.Drawing.Size(134, 125);
            this.btnGestaoClientes.TabIndex = 0;
            this.btnGestaoClientes.Text = "Gestão Clientes";
            this.btnGestaoClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestaoClientes.UseVisualStyleBackColor = false;
            this.btnGestaoClientes.Click += new System.EventHandler(this.btnGestaoClientes_Click);
            // 
            // btnGestaoCadeia
            // 
            this.btnGestaoCadeia.BackColor = System.Drawing.SystemColors.Window;
            this.btnGestaoCadeia.BackgroundImage = global::da_projeto.Properties.Resources._352514_local_restaurant_icon;
            this.btnGestaoCadeia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestaoCadeia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoCadeia.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGestaoCadeia.Location = new System.Drawing.Point(155, 288);
            this.btnGestaoCadeia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestaoCadeia.Name = "btnGestaoCadeia";
            this.btnGestaoCadeia.Size = new System.Drawing.Size(134, 125);
            this.btnGestaoCadeia.TabIndex = 1;
            this.btnGestaoCadeia.Text = "Gestão Cadeia Restaurantes";
            this.btnGestaoCadeia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestaoCadeia.UseVisualStyleBackColor = false;
            this.btnGestaoCadeia.Click += new System.EventHandler(this.btnGestaoCadeia_Click);
            // 
            // btnGestaoRest
            // 
            this.btnGestaoRest.BackColor = System.Drawing.SystemColors.Window;
            this.btnGestaoRest.BackgroundImage = global::da_projeto.Properties.Resources._185114_chef_restaurant_food_icon;
            this.btnGestaoRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestaoRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoRest.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGestaoRest.Location = new System.Drawing.Point(294, 288);
            this.btnGestaoRest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestaoRest.Name = "btnGestaoRest";
            this.btnGestaoRest.Size = new System.Drawing.Size(134, 125);
            this.btnGestaoRest.TabIndex = 2;
            this.btnGestaoRest.Text = "Gestão Individual Restaurante";
            this.btnGestaoRest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestaoRest.UseVisualStyleBackColor = false;
            this.btnGestaoRest.Click += new System.EventHandler(this.btnGestaoRest_Click);
            // 
            // btnMenuRest
            // 
            this.btnMenuRest.BackColor = System.Drawing.SystemColors.Window;
            this.btnMenuRest.BackgroundImage = global::da_projeto.Properties.Resources._2290855_check_document_done_list_paper_icon;
            this.btnMenuRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRest.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMenuRest.Location = new System.Drawing.Point(433, 288);
            this.btnMenuRest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuRest.Name = "btnMenuRest";
            this.btnMenuRest.Size = new System.Drawing.Size(134, 125);
            this.btnMenuRest.TabIndex = 3;
            this.btnMenuRest.Text = "Gestao Menu Restaurante";
            this.btnMenuRest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuRest.UseVisualStyleBackColor = false;
            this.btnMenuRest.Click += new System.EventHandler(this.btnMenuRest_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.SystemColors.Window;
            this.btnPedidos.BackgroundImage = global::da_projeto.Properties.Resources._290137_clipboard_document_file_list_report_icon;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPedidos.Location = new System.Drawing.Point(572, 288);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(134, 125);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::da_projeto.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 418);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnMenuRest);
            this.Controls.Add(this.btnGestaoRest);
            this.Controls.Add(this.btnGestaoCadeia);
            this.Controls.Add(this.btnGestaoClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestaoClientes;
        private System.Windows.Forms.Button btnGestaoCadeia;
        private System.Windows.Forms.Button btnGestaoRest;
        private System.Windows.Forms.Button btnMenuRest;
        private System.Windows.Forms.Button btnPedidos;
    }
}

