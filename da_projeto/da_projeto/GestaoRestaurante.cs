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
    public partial class GestaoRestaurante : Form
    {
        public GestaoRestaurante()
        {
            InitializeComponent();
        }
        private void AtivarTrabalhador()
        {
            txtnome.Enabled = true;
            cbmorada.Enabled = true;
            masktelemovel.Enabled = true;
            masktelemovel.Enabled = true;
            txtposicao.Enabled = true;
        }

        private void LerDados()
        {
            Restaurante restaurante = new Restaurante();

            IEnumerable<String> trabalhadores = from Tra in Pessoa
                                                where (Restaurante)comboBox1.SelectedItem = restaurante.Id
                                                select ;

            listBoxTrabalhadores.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Trabalhador>().ToList();


        }

        private void btnRegistarRestaurante_Click(object sender, EventArgs e)
        {
            AtivarTrabalhador();
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnregistar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Trabalhador selctedtrabalhador = (Trabalhador)listBoxTrabalhadores.SelectedItem;

            if (selctedtrabalhador == null)
            {
                return;
            }
            else
            {


                MenuPrincipal.restaurante.Pessoas.Remove(selctedtrabalhador);
                MenuPrincipal.restaurante.SaveChanges();
                LerDados();


            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhador = new Trabalhador();

            trabalhador.Morada = (Morada)cbmorada.SelectedItem;
            trabalhador.nome = txtnome.Text;
            trabalhador.telemovel = int.Parse(masktelemovel.Text);
            trabalhador.salario = decimal.Parse(masksalario.Text);
            trabalhador.posicao = txtposicao.Text;
            MenuPrincipal.restaurante.Pessoas.Add(trabalhador);
            MenuPrincipal.restaurante.SaveChanges();
            LerDados();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhadoredit = (Trabalhador)listBoxTrabalhadores.SelectedItem;

            if (trabalhadoredit == null)
            {
                return;
            }
            else
            {
                //var trabalhadoredit = MenuPrincipal.restaurante.Pessoas.Find(trabalhador.Id);
                trabalhadoredit.Morada = (Morada)cbmorada.SelectedItem;
                trabalhadoredit.nome = txtnome.Text;
                trabalhadoredit.telemovel = int.Parse(masktelemovel.Text);
                trabalhadoredit.salario = decimal.Parse(masksalario.Text);
                trabalhadoredit.posicao = txtposicao.Text;
                MenuPrincipal.restaurante.SaveChanges();
                LerDados();


            }
        }

        private void GestaoRestaurante_Load(object sender, EventArgs e)
        {

        }
    }
}
