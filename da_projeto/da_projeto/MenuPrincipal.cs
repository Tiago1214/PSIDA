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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoClientes gestaoClientes = new GestaoClientes();
            gestaoClientes.ShowDialog();
        }

        private void btnGestaoCadeia_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoCadeiaRest gestaoCadeiaRest = new GestaoCadeiaRest();
            gestaoCadeiaRest.ShowDialog();
        }

        private void btnGestaoRest_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoRestaurante gestaoRestaurante = new GestaoRestaurante();
            gestaoRestaurante.ShowDialog();
        }

        private void btnMenuRest_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoMenu gestaoMenu=new GestaoMenu();
            gestaoMenu.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoPedidos gestaoPedidos = new GestaoPedidos();
            gestaoPedidos.ShowDialog();
        }
    }
}
