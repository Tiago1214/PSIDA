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

        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            LerDados();
            Desativar();
        }

        private void LerDados()
        {
            var listIdsPessoas = MenuPrincipal.restaurante.Pessoas.Select(i => i.Morada.Id);
            var listIdsRestaurantes = MenuPrincipal.restaurante.Restaurantes.Select(r => r.Morada.Id);
            var moradas = MenuPrincipal.restaurante.Moradas.ToList();
            moradas.RemoveAll(x => listIdsPessoas.Contains(x.Id));
            moradas.RemoveAll(x => listIdsRestaurantes.Contains(x.Id));
            comboBox1.DataSource = moradas;
            lbclientes.DataSource = MenuPrincipal.restaurante.Pessoas.ToList<Pessoa>();
        }

        private void Desativar()
        {
            txtnome.Enabled = false;
            comboBox1.Enabled = false;
            masktxtnif.Enabled = false;
            masktxttele.Enabled = false;
            guardarbutton.Enabled = false;

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
            Ativar();
            apagarbutton.Enabled = false;
            alterarbuton.Enabled = false;
            registarbutton.Enabled = false;
            txtnome.Clear();
            masktxtnif.Clear();
            masktxttele.Clear();
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtnome.Text)==false&&
                    String.IsNullOrEmpty(masktxtnif.Text) == false && String.IsNullOrEmpty(masktxttele.Text) == false)
                {
                    var listaclientesnomes= MenuPrincipal.restaurante.Pessoas.Select(c => c.nome);
                    var listaclientestele = MenuPrincipal.restaurante.Pessoas.Select(c => c.telemovel);
                    var listaclientesnif = MenuPrincipal.restaurante.Pessoas.Select(c=>c.telemovel);
                    Cliente cliente = new Cliente();
                    cliente.Morada = (Morada)comboBox1.SelectedItem;
                    cliente.nome = txtnome.Text;
                    cliente.telemovel = int.Parse(masktxttele.Text);
                    cliente.numcontribuinte = int.Parse(masktxtnif.Text);
                    cliente.totalgasto = 0;
                    cliente.numcontribuinte = int.Parse(masktxtnif.Text);
                    MenuPrincipal.restaurante.Pessoas.Add(cliente);
                    MenuPrincipal.restaurante.SaveChanges();
                    LerDados();
                    txtnome.Clear();
                    masktxttele.Clear();
                    masktxtnif.Clear();
                }
                else
                {
                    MessageBox.Show("Os campos nome,telefone e nif já existem na base de dados, por favor insira novos dados!",
                        "Erro inserir cliente",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }


        private void alterarbuton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lbclientes.SelectedItem;

            if (cliente == null)
            {
                return;
            }
            else
            {
                var clienteedit = MenuPrincipal.restaurante.Pessoas.Find(cliente.Id);
                cliente.Morada = (Morada)comboBox1.SelectedItem;
                cliente.nome = txtnome.Text;
                cliente.telemovel = int.Parse(masktxttele.Text);
                cliente.numcontribuinte = int.Parse(masktxtnif.Text);
                MenuPrincipal.restaurante.SaveChanges();
                LerDados();


            }
        }

        private void apagarbutton_Click(object sender, EventArgs e)
        {
            Cliente selctedcliente = (Cliente)lbclientes.SelectedItem;

            if (selctedcliente == null)
            {
                return;
            }
            else
            {


                MenuPrincipal.restaurante.Pessoas.Remove(selctedcliente);
                MenuPrincipal.restaurante.SaveChanges();
                LerDados();


            }
        }

        private void lbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente editcliente = (Cliente)lbclientes.SelectedItem;
            txtnome.Text = editcliente.nome;
            comboBox1.Text = editcliente.Morada.ToString();
            masktxttele.Text = editcliente.telemovel.ToString();
            masktxtnif.Text = editcliente.numcontribuinte.ToString();
            Desativar();
            alterarbuton.Enabled = true;
            apagarbutton.Enabled = true;
            txtnome.Enabled= true;
            comboBox1.Enabled=true;
            masktxtnif.Enabled= true;
            masktxttele.Enabled= true;
        }

        private void GestaoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registarbutton.Enabled = true;
            apagarbutton.Enabled = false;
            alterarbuton.Enabled=false;
            guardarbutton.Enabled=false;
        }
    }
}