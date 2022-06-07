using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Desativar();
            LerDados();

        }
        private void LerDados()
        {
            lbclientes.DataSource = MenuPrincipal.restaurante.Pessoas.ToList<Pessoa>();

        }

        private void Desativar()
        { 
            txtnome.Enabled= false;
            cbmorada.Enabled= false;
            masktxtnif.Enabled= false;
            masktxttele.Enabled= false;
            guardarbutton.Enabled= false;

            //lbclientes.Enabled= false;
        
        }

        private void Ativar()
        {
            txtnome.Enabled = true;
            cbmorada.Enabled = true;
            masktxtnif.Enabled = true;
            masktxttele.Enabled = true;
            guardarbutton.Enabled = true;
            //lbclientes.Enabled = true;

        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ativar();
            apagarbutton.Enabled = false;
            alterarbuton.Enabled = false;
            Pessoa pessoa = new Pessoa();
            Cliente cliente = new Cliente();
            pessoa.Id = 0;
            //pessoa.idmorada = cbmorada.Text;
            //pessoa.telemovel = Convert.ToUInt16(masktxttele.Text());
            cliente.numcontribuinte = int.Parse(masktxtnif.Text);



        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            
            LerDados();
        }
    }
}
