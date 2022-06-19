using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da_projeto
{
    public partial class GestaoCadeiaRest : Form
    {

        public GestaoCadeiaRest()
        {
            InitializeComponent();
        }
        //Carregar Dados quando se abre o programa
        private void GestaoCadeiaRest_Load(object sender, EventArgs e)
        {
            LerDados();
            comboBoxAtivoCategoria.DataSource = comboBoxAtivoCategoria.Items;
            comboBoxAtivoMetodo.DataSource = comboBoxAtivoMetodo.Items;
            txtNomeRestaurante.Enabled = false;
            comboBoxMorada.Enabled = false;
            txtNomeCategoria.Enabled = false;
            comboBoxAtivoCategoria.Enabled = false;
            txtNomeCategoria.Enabled = false;
            comboBoxAtivoMetodo.Enabled = false;
            txtNomeMetodo.Enabled = false;
            comboBoxAtivoCategoria.Enabled = false;
            btnCancelarRegistoCat.Enabled = false;
            btnCancelarRegistoRest.Enabled = false;
            btnEditarCategoria.Enabled = false;
            btnEditarRestaurante.Enabled = false;
            btnEliminarCategoria.Enabled=false;
            btnEliminarRestaurante.Enabled=false;
            btnGuardarCategoria.Enabled = false;
            btnGuardarRestaurante.Enabled = false;
            btnEditarMetodo.Enabled = false;
            btnEliminarMetodo.Enabled = false;
            btnGuardarMetodo.Enabled = false;
            btnCancelarMetodo.Enabled = false;
        }
        //Esta função limpa os campos de texto
        private void LimparCampos()
        {
            txtNomeRestaurante.Clear();
            txtNomeCategoria.Clear();
            txtNomeMetodo.Clear();
        }
        //Ler Dados existentes na database e remover as moradas já usadas em registas
        private void LerDados()
        {
            listBoxRestaurantes.DataSource = MenuPrincipal.restaurante.Restaurantes.ToList<Restaurante>();
            listBoxCategorias.DataSource = MenuPrincipal.restaurante.Categorias.ToList<Categoria>();
            listBoxMetodos.DataSource=MenuPrincipal.restaurante.MetodoPagamentoes.ToList<MetodoPagamento>();
            var listIdsPessoas = MenuPrincipal.restaurante.Pessoas.Select(i => i.Morada.Id);
            var listIdsRestaurantes = MenuPrincipal.restaurante.Restaurantes.Select(r => r.Morada.Id);
            var moradas = MenuPrincipal.restaurante.Moradas.ToList();
            moradas.RemoveAll(x => listIdsPessoas.Contains(x.Id));
            moradas.RemoveAll(x => listIdsRestaurantes.Contains(x.Id));
            comboBoxMorada.DataSource = moradas;
        }
        //Esta função mete os campos ativos
        private void btnRegistarRestaurante_Click(object sender, EventArgs e)
        {
            txtNomeRestaurante.Enabled = true;
            comboBoxMorada.Enabled = true;
            btnCancelarRegistoRest.Enabled = true;
            btnGuardarRestaurante.Enabled = true;
            btnEliminarRestaurante.Enabled = false;
            btnEditarRestaurante.Enabled=false;
        }
        /*Guardar o registo do restaurante
         *Nesta função não é verificado se o restaurante já existe na base de dados porque 
         *os restaurantes podem ter o mesmo nome visto que se trata de uma cadeia 
         */
        private void btnGuardarRestaurante_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNomeRestaurante.Text)==false&& String.IsNullOrEmpty(comboBoxMorada.Text)==false)
                {
                        Restaurante restaurante = new Restaurante();
                        restaurante.nome = txtNomeRestaurante.Text;
                        restaurante.Morada = (Morada)comboBoxMorada.SelectedItem;
                        MenuPrincipal.restaurante.Restaurantes.Add(restaurante);
                        MenuPrincipal.restaurante.SaveChanges();
                        LerDados();
                        LimparCampos();
                        txtNomeRestaurante.Enabled = false;
                        comboBoxMorada.Enabled = false;
                        btnGuardarRestaurante.Enabled = false;
                        btnCancelarRegistoRest.Enabled = false;
                    //}
                }
                else
                {
                    MessageBox.Show("Os campos nome restaurante e morada devem ser preenchidos!","Aviso!",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Nesta função podemos editar o registo de um restaurante
        private void btnEditarRestaurante_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
                if (restaurante == null)
                {
                    return;
                }
                else
                {
                    if (String.IsNullOrEmpty(txtNomeRestaurante.Text) == false && String.IsNullOrEmpty(comboBoxMorada.Text) == false)
                    {
                        var clienteDb = MenuPrincipal.restaurante.Restaurantes.Find(restaurante.Id);
                        clienteDb.nome = txtNomeRestaurante.Text;
                        comboBoxMorada.Text = restaurante.Morada.ToString();
                        MenuPrincipal.restaurante.SaveChanges();
                        LerDados();
                        btnEditarRestaurante.Enabled = false;
                        btnEliminarRestaurante.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Os campos nome restaurante e morada devem ser preenchidos para poderem ser editados!", "Aviso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Esta função serve para meter os dados do restaurante selecionado na respetivas textbox e combobox 
        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante editRestaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
            txtNomeRestaurante.Text = editRestaurante.nome;
            comboBoxMorada.Text = editRestaurante.Morada.ToString();
            txtNomeRestaurante.Enabled = true;
            comboBoxMorada.Enabled = true;
            btnEditarRestaurante.Enabled = true;
            btnEliminarRestaurante.Enabled = true;
        }

        //Nesta função eliminamos um restaurante
        private void btnEliminarRestaurante_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante selectedRestaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
                if (selectedRestaurante == null)
                {
                    return;
                }
                else
                {
                    DialogResult messageBox = MessageBox.Show("Tem a certeza que pretende eliminar o " +selectedRestaurante.nome+"?",
                        "Eliminar registo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    //Caso a resposta seja igual a sim é eliminado o restaurante é da uma mensagem para informar
                    //Caso a resposta seja não o programa dá uma mensagem a dizer que o restaurante não foi eliminado
                    if (messageBox.Equals(DialogResult.Yes) == true)
                    {
                        MenuPrincipal.restaurante.Restaurantes.Remove(selectedRestaurante);
                        MenuPrincipal.restaurante.SaveChanges();
                        MessageBox.Show("Restaurante "+selectedRestaurante.nome +" eliminado");
                        LerDados();
                        btnEditarRestaurante.Enabled = false;
                        btnGuardarRestaurante.Enabled=false;
                        btnCancelarRegistoRest.Enabled = false;
                        btnEliminarRestaurante.Enabled = false;
                    }
                    else if(messageBox.Equals(DialogResult.No) == true)
                    {
                        MessageBox.Show("Restaurante " + selectedRestaurante.nome + "não foi eliminado");
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Nesta função mete-se os campos sem poderem ser alterados e são limpos campos
        private void btnCancelarRegistoRest_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeRestaurante.Enabled = false;
            comboBoxMorada.Enabled=false;
            btnCancelarRegistoRest.Enabled = false;
            btnEditarRestaurante.Enabled = false;
            btnEliminarRestaurante.Enabled = false;
            btnGuardarRestaurante.Enabled=false;
        }
        //Ativar os campos relacionados com a categoria para se poder começar a registar uma.
        private void btnRegistarCategoria_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeCategoria.Enabled = true;
            comboBoxAtivoCategoria.Enabled = true;
            btnGuardarCategoria.Enabled = true;
            btnCancelarRegistoCat.Enabled = true;
            btnEditarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
        }
        //Criação da Categoria
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNomeCategoria.Text) == false && String.IsNullOrEmpty(comboBoxAtivoCategoria.Text) == false)
                {
                    var guardarlistacat = MenuPrincipal.restaurante.Categorias.Select(c => c.nome);
                    if (guardarlistacat.Contains(txtNomeCategoria.Text))
                    {
                        MessageBox.Show("Categoria já existente!!", "Erro a Guardar Categoria",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Categoria categoria = new Categoria();
                        categoria.nome = txtNomeCategoria.Text;
                        if (comboBoxAtivoCategoria.SelectedIndex == 0)
                        {
                            categoria.ativo = true;
                        }
                        else if (comboBoxAtivoCategoria.SelectedIndex == 1)
                        {
                            categoria.ativo = false;
                        }
                        MenuPrincipal.restaurante.Categorias.Add(categoria);
                        MenuPrincipal.restaurante.SaveChanges();

                        LerDados();
                        LimparCampos();
                        txtNomeCategoria.Enabled = false;
                        comboBoxAtivoCategoria.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Os campos nome categoria e ativo devem ser preenchidos para poderem ser adicionados!", "Aviso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = (Categoria)listBoxCategorias.SelectedItem;
                if (categoria == null)
                {
                    return;
                }
                else
                {
                    var guardarlistacat = MenuPrincipal.restaurante.Categorias.Select(c => c.nome);
                    if (String.IsNullOrEmpty(txtNomeCategoria.Text) == false)
                    {
                        if (guardarlistacat.Contains(txtNomeCategoria.Text))
                        {
                            MessageBox.Show("Categoria já existente!!", "Erro a Editar Categoria",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var clienteDb = MenuPrincipal.restaurante.Categorias.Find(categoria.Id);
                            clienteDb.nome = txtNomeCategoria.Text;
                            if (comboBoxAtivoCategoria.SelectedIndex == 0)
                            {
                                clienteDb.ativo = true;
                            }
                            else if (comboBoxAtivoCategoria.SelectedIndex == 1)
                            {
                                clienteDb.ativo = false;
                            }
                            MenuPrincipal.restaurante.SaveChanges();
                            LerDados();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O nome da categoria não pode ser vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Eliminação de uma Categoria
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria selectedCategoria = (Categoria)listBoxCategorias.SelectedItem;
                if (selectedCategoria == null)
                {
                    return;
                }
                else
                {
                    DialogResult messageBox = MessageBox.Show("Tem a certeza que pretende eliminar a categoria "
                        + selectedCategoria.nome + "?", "Eliminar registo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBox.Equals(DialogResult.Yes) == true)
                    {
                        MenuPrincipal.restaurante.Categorias.Remove(selectedCategoria);
                        MenuPrincipal.restaurante.SaveChanges();
                        txtNomeCategoria.Enabled = false;
                        comboBoxAtivoCategoria.Enabled = false;
                        btnEditarCategoria.Enabled = false;
                        btnEliminarCategoria.Enabled = false;
                        btnCancelarRegistoCat.Enabled = false;
                        LerDados();
                    }
                    else if (messageBox.Equals(DialogResult.No) == true)
                    {
                        MessageBox.Show("Categoria" + selectedCategoria.nome + "não apagada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnCancelarRegistoCat_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeCategoria.Enabled = false;
            comboBoxAtivoCategoria.Enabled = false;
            btnCancelarRegistoCat.Enabled = false;
            btnGuardarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
            btnEditarCategoria.Enabled = false;
        }
        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria editCategoria = (Categoria)listBoxCategorias.SelectedItem;
            txtNomeCategoria.Text = editCategoria.nome;
            comboBoxAtivoCategoria.Text = editCategoria.GetEstado(editCategoria.ativo).ToString();
            txtNomeCategoria.Enabled = true;
            comboBoxAtivoCategoria.Enabled=true;
            btnEditarCategoria.Enabled=true;
            btnEliminarCategoria.Enabled=true;
            btnGuardarCategoria.Enabled = false;
            btnCancelarRegistoCat.Enabled=false;
        }


        //Meter campos ativos para poder registar um método
        private void btnRegistarMetodo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeMetodo.Enabled = true;
            comboBoxAtivoMetodo.Enabled=true;
            btnGuardarMetodo.Enabled = true;
            btnCancelarMetodo.Enabled = true;
            btnEditarMetodo.Enabled = false;
            btnEliminarMetodo.Enabled = false;
        }

        //Função para guardar um novo método
        private void btnGuardarMetodo_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNomeMetodo.Text) == false && String.IsNullOrEmpty(comboBoxAtivoMetodo.Text) == false)
                {
                    var guardarlistametodos = MenuPrincipal.restaurante.MetodoPagamentoes.Select(m => m.metodopagamento);
                    if (guardarlistametodos.Contains(txtNomeMetodo.Text))
                    {
                        MessageBox.Show("Método já existente!!", "Erro a Guardar Método",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MetodoPagamento metodo = new MetodoPagamento();
                        metodo.metodopagamento = txtNomeMetodo.Text;
                        if (comboBoxAtivoCategoria.SelectedIndex == 0)
                        {
                            metodo.ativo = true;
                        }
                        else if (comboBoxAtivoCategoria.SelectedIndex == 1)
                        {
                            metodo.ativo = false;
                        }

                        MenuPrincipal.restaurante.MetodoPagamentoes.Add(metodo);
                        MenuPrincipal.restaurante.SaveChanges();
                        LerDados();
                        LimparCampos();
                        txtNomeMetodo.Enabled = false;
                        comboBoxAtivoMetodo.Enabled = false;
                        btnGuardarMetodo.Enabled = false;
                        btnEditarMetodo.Enabled = false;
                        btnEliminarMetodo.Enabled = false;
                        btnCancelarMetodo.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Os campos nome método e ativo não podem ser nulos", "Erro a Guardar Método",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarMetodo_Click(object sender, EventArgs e)
        {
            try
            {
                MetodoPagamento metodo = (MetodoPagamento)listBoxMetodos.SelectedItem;
                if (metodo == null)
                {
                    return;
                }
                else
                {
                    if (String.IsNullOrEmpty(txtNomeMetodo.Text)==false)
                    {
                        var guardarlistametodos = MenuPrincipal.restaurante.MetodoPagamentoes.Select(m => m.metodopagamento);
                        if (guardarlistametodos.Contains(txtNomeMetodo.Text))
                        {
                            MessageBox.Show("O campo nome método já existe na base de dados, por favor insira outros dados",
                                "Erro editar método",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            var clienteDb = MenuPrincipal.restaurante.MetodoPagamentoes.Find(metodo.Id);
                            clienteDb.metodopagamento = txtNomeMetodo.Text;
                            if (comboBoxAtivoMetodo.SelectedIndex == 0)
                            {
                                clienteDb.ativo = true;
                            }
                            else if (comboBoxAtivoMetodo.SelectedIndex == 1)
                            {
                                clienteDb.ativo = false;
                            }
                            MenuPrincipal.restaurante.SaveChanges();
                            LerDados();
                        }   
                    }
                    else
                    {
                        MessageBox.Show("O campo nome método não pode ser nulo", "Erro a editar categoria",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEliminarMetodo_Click(object sender, EventArgs e)
        {
            MetodoPagamento selectedMetodo = (MetodoPagamento)listBoxMetodos.SelectedItem;
            if (selectedMetodo == null)
            {
                return;
            }
            else
            {
                MenuPrincipal.restaurante.MetodoPagamentoes.Remove(selectedMetodo);
                MenuPrincipal.restaurante.SaveChanges();
                LerDados();
            }
        }

        private void listBoxMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPagamento editMetodo = (MetodoPagamento)listBoxMetodos.SelectedItem;
            txtNomeMetodo.Text = editMetodo.metodopagamento;
            comboBoxAtivoCategoria.Text = editMetodo.GetEstado(editMetodo.ativo).ToString();
            txtNomeMetodo.Enabled = true;
            comboBoxAtivoMetodo.Enabled = true;
            btnEditarMetodo.Enabled = true;
            btnEliminarMetodo.Enabled = true;
            btnGuardarMetodo.Enabled = false;
            btnCancelarMetodo.Enabled = false;
        }
        private void btnCancelarMetodo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeMetodo.Enabled = false;
            comboBoxAtivoMetodo.Enabled = false;
            btnCancelarMetodo.Enabled=false;
            btnGuardarMetodo.Enabled=false;
            btnEliminarMetodo.Enabled = false;
            btnEditarMetodo.Enabled = false;
        }


        //Função para abrir formulário do Menu Principal quando este se fecha
        private void GestaoCadeiaRest_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MenuPrincipal menu= new MenuPrincipal();
            menu.Show();
        }
    }
}
