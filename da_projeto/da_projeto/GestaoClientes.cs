using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace da_projeto
{
    public partial class GestaoClientes : Form
    {
        
        public GestaoClientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuprincipal = new MenuPrincipal();
            menuprincipal.ShowDialog();
        }

        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            //Desativar();
            MenuPrincipal.restaurante = new RestauranteModelContainer();
            
            comboBox1.DataSource = MenuPrincipal.restaurante.Moradas.ToList();
            LerDados();

        }
        private void LerDados()
        {
            lbclientes.DataSource = MenuPrincipal.restaurante.Pessoas.ToList<Pessoa>();

        }

        private void Desativar()
        { 
            txtnome.Enabled= false;
            comboBox1.Enabled= false;
            masktxtnif.Enabled= false;
            masktxttele.Enabled= false;
            guardarbutton.Enabled= false;

            //lbclientes.Enabled= false;
        
        }

        private void Ativar()
        {
            txtnome.Enabled = true;
            comboBox1.Enabled = true;
            masktxtnif.Enabled = true;
            masktxttele.Enabled = true;
            guardarbutton.Enabled = true;
            //lbclientes.Enabled = true;

        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ativar();
            apagarbutton.Enabled = false;
            alterarbuton.Enabled = false;
            
            Cliente cliente = new Cliente();
            cliente.Morada = (Morada) comboBox1.SelectedItem;
            cliente.nome = txtnome.Text;
            cliente.telemovel =int.Parse(masktxttele.Text);
            cliente.numcontribuinte = int.Parse(masktxtnif.Text);
            cliente.totalgasto = 0;

            MenuPrincipal.restaurante.Pessoas.Add(cliente);
            MenuPrincipal.restaurante.SaveChanges();
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            
            LerDados();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
