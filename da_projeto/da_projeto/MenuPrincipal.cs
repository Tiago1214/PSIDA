using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace da_projeto
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestaoClientes_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            GestaoClientes clientes= new GestaoClientes();
            clientes.Show();
        }
    }
}
