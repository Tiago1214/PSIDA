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

        //Carregar Dados quando se abre o formulário
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

        //Função que ajuda a carregar dados quando se abre o formulário
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

        //botão de registar ativa campos e botões para ser possível a inserção de um novo registo de trabalhador
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtnome.Enabled = true;
            txtPosicao.Enabled = true;
            txtSalario.Enabled = true;
            masktxttele.Enabled = true;
            comboBoxMorada.Enabled = true;
            Limpar();
            comboBoxMorada.DataSource = comboBoxMorada.Items;
        }

        //Função que mete a textbox de salário a só aceitar números positivos e não deixar escrever letras ou símbolos.
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

        //Guardar o registo de um trabalhador
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
                            //Validação de salário não é necessário porque a função que só deixa escrever números na txtSalario só deixa
                            //escrever números positivos
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
                                MessageBox.Show("O telemóvel tem de ter exatamente 9 dígitos ou o salário tem de ser maior que 0.", "Erro Guardar Trabalhador",
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

        //Editar o registo de um trabalhador
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
                            //Verificar se o número de telemóvel tem 9 dígitos inseridos
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

        //Selecionar um trabalhador para editar
        private void listBoxTrabalhadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trabalhador editTrabalhador = (Trabalhador)listBoxTrabalhadores.SelectedItem;
            if (editTrabalhador == null)
            {
                MessageBox.Show("selecione um trabalhador para pode editar ou eliminar","Selecionar Trabalhador",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                txtnome.Text = editTrabalhador.nome;
                comboBoxMorada.SelectedItem = editTrabalhador.Morada;
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
        }

        //Selecionar restaurante para adicionar trabalhador relacionado com este mesmo
        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
            if (rest == null)
            {
                MessageBox.Show("selecione um restaurante para pode adicionar trabalhadores", "Adicionar Trabalhador",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listBoxItemMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == rest.Id).ToList<ItemMenu>();
                listBoxTrabalhadores.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Trabalhador>().Where(t => t.RestauranteId == rest.Id).ToList();
            }
        }

        //Limpar Campos
        private void Limpar()
        {
            txtnome.Clear();
            txtPosicao.Clear();
            txtSalario.Clear();
            masktxttele.Clear();
        }

        //Eliminar Trabalhador
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
                        var listapedidostrabalhador = MenuPrincipal.restaurante.Pedidoes.Select(p => p.TrabalhadorId);
                        if (listapedidostrabalhador.Contains(selectTrabalhador.Id))
                        {
                            MessageBox.Show("Erro a eliminar trabalhador por o mesmo estar associado a um pedido.",
                                "Erro a eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MenuPrincipal.restaurante.Pessoas.Remove(selectTrabalhador);
                            MenuPrincipal.restaurante.SaveChanges();
                            LerDados();
                            btnEditar.Enabled = false;
                            btnEliminar.Enabled = false;
                            btnCancelar.Enabled = false;
                            btnGuardar.Enabled = false;
                            Limpar();
                            MessageBox.Show("Trabalhador " + selectTrabalhador.nome + " foi eliminado", "Trabalhador Eliminado", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        }
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

        //Abrir menu de pedidos
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            GestaoPedidos pedidos = new GestaoPedidos();
            pedidos.Show();
        }

        //abrir menu de items de menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            GestaoMenu menu = new GestaoMenu();
            menu.Show();
        }
    }
}
