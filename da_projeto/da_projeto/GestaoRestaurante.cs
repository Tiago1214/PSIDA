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
        private void GestaoRestaurante_Load(object sender, EventArgs e)
        {
            LerDados();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            txtnome.Enabled = false;
            txtPosicao.Enabled = false;
            txtSalario.Enabled = false;
            masktxttele.Enabled = false;
            comboBoxMorada.Enabled = false;
        }
        private void LerDados()
        {
            listBoxRestaurantes.DataSource = MenuPrincipal.restaurante.Restaurantes.ToList<Restaurante>();
            var listIdsPessoas = MenuPrincipal.restaurante.Pessoas.Select(i => i.Morada.Id);
            var listIdsRestaurantes = MenuPrincipal.restaurante.Restaurantes.Select(r => r.Morada.Id);
            var moradas = MenuPrincipal.restaurante.Moradas.ToList();
            moradas.RemoveAll(x => listIdsPessoas.Contains(x.Id));
            moradas.RemoveAll(x => listIdsRestaurantes.Contains(x.Id));
            comboBoxMorada.DataSource = moradas;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtnome.Enabled = true;
            txtPosicao.Enabled = true;
            txtSalario.Enabled = true;
            masktxttele.Enabled = true;
            comboBoxMorada.Enabled = true;
            txtnome.Clear();
            txtPosicao.Clear();
            txtSalario.Clear();
            masktxttele.Clear();
            comboBoxMorada.DataSource = comboBoxMorada.Items;
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
                if (rest == null)
                {
                    MessageBox.Show("Nenhum Restaurante selecionado", "Erro selecionar Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //Criar Trabalhador
                    Trabalhador trabalhador = new Trabalhador();
                    if(String.IsNullOrEmpty(txtnome.Text)==false&&String.IsNullOrEmpty(txtPosicao.Text)==false&&
                        String.IsNullOrEmpty(txtSalario.Text) == false && String.IsNullOrEmpty(masktxttele.Text) == false)
                    {
                        //Verificar se já existe este número na base de dados
                        var verifytelemovel = MenuPrincipal.restaurante.Pessoas.Select(t => t.telemovel);
                        if (verifytelemovel.Contains(int.Parse(masktxttele.Text)))
                        {
                            MessageBox.Show("Número de telemóvel já existente na base de dados, por favor insira um novo número de telemóvel"
                                ,"Erro Guardar Trabalhador",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (masktxttele.Text.Length == 9)
                            {
                                trabalhador.nome = txtnome.Text;
                                trabalhador.Morada = (Morada)comboBoxMorada.SelectedItem;
                                trabalhador.telemovel = int.Parse(masktxttele.Text);
                                trabalhador.salario = int.Parse(txtSalario.Text);
                                trabalhador.posicao = txtPosicao.Text;
                                trabalhador.RestauranteId = rest.Id;
                                trabalhador.Restaurante = rest;
                                MenuPrincipal.restaurante.Pessoas.Add(trabalhador);
                                MenuPrincipal.restaurante.SaveChanges();
                                listBoxTrabalhadores.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Trabalhador>().Where(t => t.RestauranteId == rest.Id).ToList();
                                Limpar();
                                LerDados();
                                comboBoxMorada.Enabled = false;
                                txtnome.Enabled = false;
                                txtPosicao.Enabled = false;
                                txtSalario.Enabled = false;
                                masktxttele.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("O telemóvel tem de ter exatamente 9 dígitos.", "Erro Guardar Trabalhador",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Os campos são todos obrigatórios.", "Erro Guardar Trabalhador",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Trabalhador editTrabalhador = (Trabalhador)listBoxTrabalhadores.SelectedItem;
                //Verificar se existe algum registo selecionado
                if (editTrabalhador == null)
                {
                    MessageBox.Show("Selecione um registo de um trabalhador para editar");
                }
                else
                {
                    //Verificar se os campos estão todos preenchidos
                    if (String.IsNullOrEmpty(txtnome.Text) == false && String.IsNullOrEmpty(txtPosicao.Text) == false &&
                        String.IsNullOrEmpty(txtSalario.Text) == false && String.IsNullOrEmpty(masktxttele.Text) == false)
                    {
                        var verifytelemovel = MenuPrincipal.restaurante.Pessoas.Select(t => t.telemovel);
                        if (verifytelemovel.Contains(int.Parse(masktxttele.Text))&&editTrabalhador.telemovel.ToString()!=masktxttele.Text)
                        {
                            MessageBox.Show("Número de telemóvel já existente na base de dados, por favor insira um novo número de telemóvel"
                                , "Erro a Editar Trabalhador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (masktxttele.Text.Length == 9)
                            {
                                editTrabalhador.nome = txtnome.Text;
                                if (editTrabalhador.Morada.ToString() != comboBoxMorada.Text)
                                {
                                    editTrabalhador.Morada = (Morada)comboBoxMorada.SelectedItem;
                                }
                                editTrabalhador.telemovel = int.Parse(masktxttele.Text);
                                editTrabalhador.salario = int.Parse(txtSalario.Text);
                                editTrabalhador.posicao = txtPosicao.Text;
                                MenuPrincipal.restaurante.SaveChanges();
                                LerDados();
                                btnEditar.Enabled = false;
                                btnEliminar.Enabled = false;
                                txtnome.Enabled = false;
                                txtPosicao.Enabled = false;
                                txtSalario.Enabled = false;
                                masktxttele.Enabled = false;
                                comboBoxMorada.Enabled = false;
                                Limpar();
                            }
                            else
                            {
                                MessageBox.Show("O telemóvel tem de ter exatamente 9 dígitos.", "Erro Guardar Trabalhador",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxTrabalhadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trabalhador editTrabalhador = (Trabalhador)listBoxTrabalhadores.SelectedItem;
            txtnome.Text = editTrabalhador.nome;
            comboBoxMorada.Text = editTrabalhador.Morada.ToString();
            txtPosicao.Text = editTrabalhador.posicao;
            txtSalario.Text = editTrabalhador.salario.ToString();
            masktxttele.Text = editTrabalhador.telemovel.ToString();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtnome.Enabled = true;
            txtPosicao.Enabled = true;
            txtSalario.Enabled = true;
            masktxttele.Enabled = true;
            comboBoxMorada.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
            listBoxItemMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == rest.Id).ToList<ItemMenu>();
            listBoxTrabalhadores.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Trabalhador>().Where(t => t.RestauranteId == rest.Id).ToList();
        }

        private void Limpar()
        {
            txtnome.Clear();
            txtPosicao.Clear();
            txtSalario.Clear();
            masktxttele.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Trabalhador selectTrabalhador = (Trabalhador)listBoxTrabalhadores.SelectedItem;
                if (selectTrabalhador == null)
                {
                    MessageBox.Show("Tem de selecionar um trabalhador para este poder ser eliminado");
                }
                else
                {
                    DialogResult messageBox = MessageBox.Show("Tem a certeza que pretende eliminar o cliente " +
                        selectTrabalhador.nome + "?", "Eliminar registo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBox.Equals(DialogResult.Yes) == true)
                    {
                        MenuPrincipal.restaurante.Pessoas.Remove(selectTrabalhador);
                        MenuPrincipal.restaurante.SaveChanges();
                        LerDados();
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnGuardar.Enabled = false;
                        Limpar();
                        MessageBox.Show("Trabalhador " + selectTrabalhador.nome + " foi eliminado", "Cliente Eliminado", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    else if (messageBox.Equals(DialogResult.No) == true)
                    {
                        MessageBox.Show("Trabalhador " + selectTrabalhador.nome + " não foi eliminado");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GestaoRestaurante_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoPedidos pedidos = new GestaoPedidos();
            pedidos.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoMenu menu = new GestaoMenu();
            menu.Show();
        }
    }
}
