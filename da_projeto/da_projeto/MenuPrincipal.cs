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
    public partial class MenuPrincipal : Form
    {
        public static RestauranteModelContainer restaurante;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        public MenuPrincipal()
        {
            InitializeComponent();
            restaurante = new RestauranteModelContainer();
        }

        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {
            GestaoClientes gestaoClientes = new GestaoClientes();
            gestaoClientes.ShowDialog();
        }

        private void btnGestaoCadeia_Click(object sender, EventArgs e)
        {
            GestaoCadeiaRest gestaoCadeiaRest = new GestaoCadeiaRest();
            gestaoCadeiaRest.ShowDialog();
        }

        private void btnGestaoRest_Click(object sender, EventArgs e)
        {
            GestaoRestaurante gestaoRestaurante = new GestaoRestaurante();
            gestaoRestaurante.ShowDialog();
        }

        private void btnMenuRest_Click(object sender, EventArgs e)
        {
            GestaoMenu gestaoMenu=new GestaoMenu();
            gestaoMenu.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            GestaoPedidos gestaoPedidos = new GestaoPedidos();
            gestaoPedidos.ShowDialog();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
