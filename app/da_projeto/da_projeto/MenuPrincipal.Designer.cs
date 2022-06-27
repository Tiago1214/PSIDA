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
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.btnGestaoClientes = new System.Windows.Forms.Button();
            this.btnGestaoRestaurante = new System.Windows.Forms.Button();
            this.btnMenuRestaurante = new System.Windows.Forms.Button();
            this.btnGestaoPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.BackColor = System.Drawing.Color.White;
            this.btnRestaurante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurante.BackgroundImage")));
            this.btnRestaurante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurante.Location = new System.Drawing.Point(523, 38);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(198, 147);
            this.btnRestaurante.TabIndex = 6;
            this.btnRestaurante.Text = "Restaurantes";
            this.btnRestaurante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestaurante.UseVisualStyleBackColor = false;
            
            // 
            // btnGestaoClientes
            // 
            this.btnGestaoClientes.BackColor = System.Drawing.Color.White;
            this.btnGestaoClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGestaoClientes.BackgroundImage")));
            this.btnGestaoClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoClientes.ForeColor = System.Drawing.Color.Black;
            this.btnGestaoClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestaoClientes.Location = new System.Drawing.Point(318, 38);
            this.btnGestaoClientes.Name = "btnGestaoClientes";
            this.btnGestaoClientes.Size = new System.Drawing.Size(199, 147);
            this.btnGestaoClientes.TabIndex = 5;
            this.btnGestaoClientes.Text = "Gestão de Clientes";
            this.btnGestaoClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestaoClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestaoClientes.UseVisualStyleBackColor = false;
            this.btnGestaoClientes.Click += new System.EventHandler(this.btnGestaoClientes_Click);
            // 
            // btnGestaoRestaurante
            // 
            this.btnGestaoRestaurante.BackColor = System.Drawing.Color.White;
            this.btnGestaoRestaurante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGestaoRestaurante.BackgroundImage")));
            this.btnGestaoRestaurante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestaoRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoRestaurante.Location = new System.Drawing.Point(318, 191);
            this.btnGestaoRestaurante.Name = "btnGestaoRestaurante";
            this.btnGestaoRestaurante.Size = new System.Drawing.Size(199, 147);
            this.btnGestaoRestaurante.TabIndex = 7;
            this.btnGestaoRestaurante.Text = "Gestão Restaurante";
            this.btnGestaoRestaurante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestaoRestaurante.UseVisualStyleBackColor = false;
            
            // 
            // btnMenuRestaurante
            // 
            this.btnMenuRestaurante.BackColor = System.Drawing.Color.White;
            this.btnMenuRestaurante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuRestaurante.BackgroundImage")));
            this.btnMenuRestaurante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRestaurante.Location = new System.Drawing.Point(523, 191);
            this.btnMenuRestaurante.Name = "btnMenuRestaurante";
            this.btnMenuRestaurante.Size = new System.Drawing.Size(198, 147);
            this.btnMenuRestaurante.TabIndex = 8;
            this.btnMenuRestaurante.Text = "Menu Restaurante";
            this.btnMenuRestaurante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuRestaurante.UseVisualStyleBackColor = false;
            
            // 
            // btnGestaoPedidos
            // 
            this.btnGestaoPedidos.BackColor = System.Drawing.Color.White;
            this.btnGestaoPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGestaoPedidos.BackgroundImage")));
            this.btnGestaoPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestaoPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoPedidos.Location = new System.Drawing.Point(318, 344);
            this.btnGestaoPedidos.Name = "btnGestaoPedidos";
            this.btnGestaoPedidos.Size = new System.Drawing.Size(403, 147);
            this.btnGestaoPedidos.TabIndex = 9;
            this.btnGestaoPedidos.Text = "Gestão de Pedidos";
            this.btnGestaoPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestaoPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGestaoPedidos.UseVisualStyleBackColor = false;
            
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.btnGestaoPedidos);
            this.Controls.Add(this.btnMenuRestaurante);
            this.Controls.Add(this.btnGestaoRestaurante);
            this.Controls.Add(this.btnRestaurante);
            this.Controls.Add(this.btnGestaoClientes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button btnGestaoClientes;
        private System.Windows.Forms.Button btnGestaoRestaurante;
        private System.Windows.Forms.Button btnMenuRestaurante;
        private System.Windows.Forms.Button btnGestaoPedidos;
    }
}

