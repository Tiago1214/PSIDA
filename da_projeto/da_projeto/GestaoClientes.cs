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
        public static restaurantebdContainer restaurante;
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
            restaurante = new restaurantebdContainer();
            LerDados();

        }
        private void LerDados()
        {
            lbclientes.DataSource = restaurante.Pessoas.ToList<Pessoa>();

        }

        private void LerDadosMorada()
        {
            List<Morada> listMorada = new Morada();
            cbmorada.DataSource = listMorada;
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
            Morada morada = new Morada();
            Cliente cliente = new Cliente();
            pessoa.nome = txtnome.Text;
            pessoa.idmorada = morada.id;
            pessoa.telemovel = masktxttele.Text();
            cliente.numcontribuinte = masktxtnif.ToString();



        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {

            restaurante.SaveChanges();
            LerDados();
        }
    }
}
