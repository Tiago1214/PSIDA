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
            comboBoxMorada.DataSource = MenuPrincipal.restaurante.Moradas.ToList();
            txtNomeRestaurante.Enabled = false;
            comboBoxMorada.Enabled = false;
            //comboBoxMorada.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBoxAtivoCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNomeCategoria.Enabled = false;
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
            comboBoxAtivoCategoria.Text = "Sim";
            txtNomeMetodo.Clear();
            comboBoxAtivoMetodo.Text = "Sim";
        }
        //Ler Dados existentes na database
        private void LerDados()
        {
            listBoxRestaurantes.DataSource = MenuPrincipal.restaurante.Restaurantes.ToList<Restaurante>();
            listBoxCategorias.DataSource = MenuPrincipal.restaurante.Categorias.ToList<Categoria>();
            listBoxMetodos.DataSource=MenuPrincipal.restaurante.MetodoPagamentoes.ToList<MetodoPagamento>();
        }
        //Esta função mete os campos ativos
        private void btnRegistarRestaurante_Click(object sender, EventArgs e)
        {
            txtNomeRestaurante.Enabled = true;
            comboBoxMorada.Enabled = true;
            btnCancelarRegistoRest.Enabled = true;
            btnGuardarRestaurante.Enabled = true;    
        }
        //Guardar o registo do restaurante
        private void btnGuardarRestaurante_Click(object sender, EventArgs e)
        {
            if (txtNomeRestaurante.Text != null & comboBoxMorada.Text != null)
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
            }
        }
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
            if (txtNomeCategoria.Text != null && comboBoxAtivoCategoria.Text != null)
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
        //Eliminação de uma Categoria
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            Categoria selectedCategoria =(Categoria) listBoxCategorias.SelectedItem;
            if (selectedCategoria == null)
            {
                return;
            }
            else
            {
                MenuPrincipal.restaurante.Categorias.Remove(selectedCategoria);
                MenuPrincipal.restaurante.SaveChanges();
                LerDados();
            }
        }
        //Edição de uma categoria
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)listBoxCategorias.SelectedItem;
            if (categoria == null)
            {
                return;
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
        }

        private void btnRegistarMetodo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeMetodo.Enabled = true;
            comboBoxAtivoMetodo.Enabled=true;
            btnGuardarMetodo.Enabled = true;
            btnCancelarMetodo.Enabled = true;
            btnEditarMetodo.Enabled = false;
            btnGuardarMetodo.Enabled = false;
        }

        private void btnGuardarMetodo_Click(object sender, EventArgs e)
        {
            if (txtNomeMetodo.Text != null && comboBoxAtivoMetodo.Text != null)
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
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }

        private void btnEditarMetodo_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodo = (MetodoPagamento)listBoxMetodos.SelectedItem;
            if (metodo == null)
            {
                return;
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
    }
}
