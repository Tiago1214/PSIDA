namespace da_projeto
{
    partial class GestaoRestaurante
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnregistar = new System.Windows.Forms.Button();
            this.listBoxTrabalhadores = new System.Windows.Forms.ListBox();
            this.cbmorada = new System.Windows.Forms.ComboBox();
            this.masktelemovel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.masksalario = new System.Windows.Forms.MaskedTextBox();
            this.txtposicao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbmenusrestaurante = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(690, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtposicao);
            this.groupBox1.Controls.Add(this.masksalario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbmorada);
            this.groupBox1.Controls.Add(this.masktelemovel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnregistar);
            this.groupBox1.Controls.Add(this.listBoxTrabalhadores);
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(406, 537);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalhadores";
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::da_projeto.Properties.Resources.Save_icon;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(68, 16);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(57, 57);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = global::da_projeto.Properties.Resources.Messaging_Trash_icon;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(191, 16);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(55, 57);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = global::da_projeto.Properties.Resources.Pencil_icon;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(131, 16);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(55, 57);
            this.btneditar.TabIndex = 2;
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnregistar
            // 
            this.btnregistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistar.Image = global::da_projeto.Properties.Resources.Add_icon__1_;
            this.btnregistar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistar.Location = new System.Drawing.Point(5, 16);
            this.btnregistar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Size = new System.Drawing.Size(57, 57);
            this.btnregistar.TabIndex = 1;
            this.btnregistar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistar.UseVisualStyleBackColor = true;
            this.btnregistar.Click += new System.EventHandler(this.btnRegistarRestaurante_Click);
            // 
            // listBoxTrabalhadores
            // 
            this.listBoxTrabalhadores.FormattingEnabled = true;
            this.listBoxTrabalhadores.ItemHeight = 16;
            this.listBoxTrabalhadores.Location = new System.Drawing.Point(0, 270);
            this.listBoxTrabalhadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTrabalhadores.Name = "listBoxTrabalhadores";
            this.listBoxTrabalhadores.Size = new System.Drawing.Size(395, 260);
            this.listBoxTrabalhadores.TabIndex = 0;
            // 
            // cbmorada
            // 
            this.cbmorada.FormattingEnabled = true;
            this.cbmorada.Location = new System.Drawing.Point(144, 135);
            this.cbmorada.Name = "cbmorada";
            this.cbmorada.Size = new System.Drawing.Size(256, 24);
            this.cbmorada.TabIndex = 16;
            // 
            // masktelemovel
            // 
            this.masktelemovel.Location = new System.Drawing.Point(144, 173);
            this.masktelemovel.Mask = "000000000";
            this.masktelemovel.Name = "masktelemovel";
            this.masktelemovel.Size = new System.Drawing.Size(75, 22);
            this.masktelemovel.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telemovel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Morada";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(144, 98);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(256, 22);
            this.txtnome.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Posição";
            // 
            // masksalario
            // 
            this.masksalario.Location = new System.Drawing.Point(144, 207);
            this.masksalario.Mask = "000000.00";
            this.masksalario.Name = "masksalario";
            this.masksalario.Size = new System.Drawing.Size(75, 22);
            this.masksalario.TabIndex = 18;
            // 
            // txtposicao
            // 
            this.txtposicao.Location = new System.Drawing.Point(144, 243);
            this.txtposicao.Name = "txtposicao";
            this.txtposicao.Size = new System.Drawing.Size(100, 22);
            this.txtposicao.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Salário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.lbmenusrestaurante);
            this.groupBox2.Location = new System.Drawing.Point(430, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(406, 537);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menus";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(68, 33);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(256, 24);
            this.comboBox3.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::da_projeto.Properties.Resources.Back_2_2_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(842, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 57);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::da_projeto.Properties.Resources.Messaging_Trash_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(68, 472);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Desassociar Menu do restaurante";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::da_projeto.Properties.Resources.Add_icon__1_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(68, 63);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 57);
            this.button5.TabIndex = 1;
            this.button5.Text = "Associar menu ao restaurante";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lbmenusrestaurante
            // 
            this.lbmenusrestaurante.FormattingEnabled = true;
            this.lbmenusrestaurante.ItemHeight = 16;
            this.lbmenusrestaurante.Location = new System.Drawing.Point(5, 135);
            this.lbmenusrestaurante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbmenusrestaurante.Name = "lbmenusrestaurante";
            this.lbmenusrestaurante.Size = new System.Drawing.Size(395, 324);
            this.lbmenusrestaurante.TabIndex = 0;
            // 
            // GestaoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "GestaoRestaurante";
            this.Text = "GestaoRestaurante";
            this.Load += new System.EventHandler(this.GestaoRestaurante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnregistar;
        private System.Windows.Forms.ListBox listBoxTrabalhadores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtposicao;
        private System.Windows.Forms.MaskedTextBox masksalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmorada;
        private System.Windows.Forms.MaskedTextBox masktelemovel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lbmenusrestaurante;
        private System.Windows.Forms.Button button1;
    }
}