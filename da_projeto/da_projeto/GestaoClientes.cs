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
        //Carregar Dados mal se abre o formulário
        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            LerDados();
            Desativar();
        }

        //Função Ler Dados serve para carregar dados para a listbox e combobox
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

        //Desativar botões e campos
        private void Desativar()
        {
            txtnome.Enabled = false;
            comboBox1.Enabled = false;
            masktxtnif.Enabled = false;
            masktxttele.Enabled = false;
            guardarbutton.Enabled = false;

            //lbclientes.Enabled= false;

        }

        //Ativar botões e campos
        private void Ativar()
        {
            txtnome.Enabled = true;
            comboBox1.Enabled = true;
            masktxtnif.Enabled = true;
            masktxttele.Enabled = true;
            guardarbutton.Enabled = true;
            //lbclientes.Enabled = true;

        }

        //Ativar campos para ser possível criar um novo registo de um cliente
        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ativar();
            apagarbutton.Enabled = false;
            alterarbuton.Enabled = false;
            registarbutton.Enabled = false;
            txtnome.Clear();
            masktxtnif.Clear();
            masktxttele.Clear();
            comboBox1.DataSource = comboBox1.Items;
        }

        //Função para guardar clientes
        private void guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar se os campos tão vazios
                if (String.IsNullOrEmpty(txtnome.Text) == false &&
                    String.IsNullOrEmpty(masktxtnif.Text) == false && String.IsNullOrEmpty(masktxttele.Text) == false)
                {
                    var listaclientestele = MenuPrincipal.restaurante.Pessoas.Select(c => c.telemovel);
                    var listaclientesnif = MenuPrincipal.restaurante.Pessoas.OfType<Cliente>().Select(c => c.numcontribuinte);
                    //Verificar se os dados do cliente já existem na base de dados, se já existir dá uma mensagem de erro 
                    //senão guarda o novo cliente
                    if (listaclientesnif.Contains(int.Parse(masktxtnif.Text)) || listaclientestele.Contains(int.Parse(masktxttele.Text)))
                    {
                        MessageBox.Show("Dados de nif ou telemovel cliente são únicos" +
                            "!!", "Erro a Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (masktxtnif.Text.Length == 9 && masktxttele.Text.Length == 9)
                        {
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
                            txtnome.Enabled = false;
                            masktxttele.Enabled = false;
                            masktxtnif.Enabled = false;
                            guardarbutton.Enabled = false;
                            cancelarbutton.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Dados de nif ou telemovel tem de ter exatamente 9 dígitos" +
                            "!!", "Erro a Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Os campos são todos obrigatórios!!",
                        "Erro inserir cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Função para alterar registo de cliente
        private void alterarbuton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)lbclientes.SelectedItem;
                //Verificar se existe algum cliente selecionado
                if (cliente == null)
                {
                    MessageBox.Show("Selecione um registo de um cliente para editar");
                }
                else
                {
                    //Verificar se os campos tão vazios
                    if (String.IsNullOrEmpty(txtnome.Text) == false &&
                        String.IsNullOrEmpty(masktxtnif.Text) == false && String.IsNullOrEmpty(masktxttele.Text) == false)
                    {
                        var listaclientestele = MenuPrincipal.restaurante.Pessoas.Select(c => c.telemovel);
                        var listaclientesnif = MenuPrincipal.restaurante.Pessoas.OfType<Cliente>().Select(c => c.numcontribuinte);
                        /*Verificar se já existe algum registo com este número de telefone e nif, caso isso 
                         * acontece não atualiza nem o nif nem o telefone
                        */
                        if (listaclientesnif.Contains(int.Parse(masktxtnif.Text)) && listaclientestele.Contains(int.Parse(masktxttele.Text)))
                        {
                            var clienteedit = MenuPrincipal.restaurante.Pessoas.Find(cliente.Id);
                            if (cliente.Morada.ToString() != comboBox1.Text)
                            {
                                cliente.Morada = (Morada)comboBox1.SelectedItem;
                            }
                            cliente.nome = txtnome.Text;
                            MenuPrincipal.restaurante.SaveChanges();
                            LerDados();
                            alterarbuton.Enabled = false;
                            apagarbutton.Enabled = false;
                            txtnome.Enabled = false;
                            comboBox1.Enabled = false;
                            masktxtnif.Enabled = false;
                            masktxttele.Enabled = false;
                            txtnome.Clear();
                            masktxtnif.Clear();
                            masktxttele.Clear();
                        }
                        /*Verificar se já existe algum registo com este nif, caso isso 
                        * acontece não atualiza o nif
                        */
                        else if (listaclientesnif.Contains(int.Parse(masktxtnif.Text)))
                        {
                            if (masktxttele.Text.Length == 9)
                            {
                                var clienteedit = MenuPrincipal.restaurante.Pessoas.Find(cliente.Id);
                                if (cliente.Morada.ToString() != comboBox1.Text)
                                {
                                    cliente.Morada = (Morada)comboBox1.SelectedItem;
                                }
                                cliente.nome = txtnome.Text;
                                cliente.telemovel = int.Parse(masktxttele.Text);
                                MenuPrincipal.restaurante.SaveChanges();
                                LerDados();
                                alterarbuton.Enabled = false;
                                apagarbutton.Enabled = false;
                                txtnome.Enabled = false;
                                comboBox1.Enabled = false;
                                masktxtnif.Enabled = false;
                                masktxttele.Enabled = false;
                                txtnome.Clear();
                                masktxtnif.Clear();
                                masktxttele.Clear();
                            }
                            else
                            {
                                MessageBox.Show("O campo telefone ou nif tem de ter exatamente 9 dígitos","Erro editar Cliente",
                                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        /*Verificar se já existe algum registo com este telefone, caso isso 
                        * acontece não atualiza o telefone
                        */
                        else if (listaclientesnif.Contains(int.Parse(masktxttele.Text)))
                        {
                            if (masktxtnif.Text.Length == 9)
                            {
                                var clienteedit = MenuPrincipal.restaurante.Pessoas.Find(cliente.Id);
                                if (cliente.Morada.ToString() != comboBox1.Text)
                                {
                                    cliente.Morada = (Morada)comboBox1.SelectedItem;
                                }
                                cliente.nome = txtnome.Text;
                                cliente.numcontribuinte = int.Parse(masktxtnif.Text);
                                MenuPrincipal.restaurante.SaveChanges();
                                LerDados();
                                alterarbuton.Enabled = false;
                                apagarbutton.Enabled = false;
                                txtnome.Enabled = false;
                                comboBox1.Enabled = false;
                                masktxtnif.Enabled = false;
                                masktxttele.Enabled = false;
                                txtnome.Clear();
                                masktxtnif.Clear();
                                masktxttele.Clear();
                            }
                            else
                            {
                                MessageBox.Show("O campo telefone ou nif tem de ter exatamente 9 dígitos", "Erro editar Cliente",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        /*Atualiza tudo*/
                        else
                        {
                            if (masktxtnif.Text.Length == 9 && masktxttele.Text.Length == 9)
                            {
                                var clienteedit = MenuPrincipal.restaurante.Pessoas.Find(cliente.Id);
                                if (cliente.Morada.ToString() != comboBox1.Text)
                                {
                                    cliente.Morada = (Morada)comboBox1.SelectedItem;
                                }
                                cliente.nome = txtnome.Text;
                                cliente.numcontribuinte = int.Parse(masktxtnif.Text);
                                cliente.telemovel = int.Parse(masktxttele.Text);
                                MenuPrincipal.restaurante.SaveChanges();
                                LerDados();
                                alterarbuton.Enabled = false;
                                apagarbutton.Enabled = false;
                                txtnome.Enabled = false;
                                comboBox1.Enabled = false;
                                masktxtnif.Enabled = false;
                                masktxttele.Enabled = false;
                                txtnome.Clear();
                                masktxtnif.Clear();
                                masktxttele.Clear();
                            }
                            else
                            {
                                MessageBox.Show("O campo telefone ou nif tem de ter exatamente 9 dígitos", "Erro editar Cliente",
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

        //Função para apagar um cliente
        private void apagarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente selectedcliente = (Cliente)lbclientes.SelectedItem;
                //Verificar se existe algum cliente selecionado
                if (selectedcliente == null)
                {
                    return;
                }
                else
                {
                    //Perguntar se o utilizador quer mesmo apagar o registo
                    //Caso a resposta seja igual a sim é eliminado o cliente é da uma mensagem para informar
                    //Caso a resposta seja não o programa dá uma mensagem a dizer que o cliente não foi eliminado
                    DialogResult messageBox = MessageBox.Show("Tem a certeza que pretende eliminar o cliente " +
                        selectedcliente.nome + "?", "Eliminar registo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBox.Equals(DialogResult.Yes) == true)
                    {
                        MenuPrincipal.restaurante.Pessoas.Remove(selectedcliente);
                        MenuPrincipal.restaurante.SaveChanges();
                        LerDados();
                        alterarbuton.Enabled = false;
                        guardarbutton.Enabled = false;
                        cancelarbutton.Enabled = false;
                        apagarbutton.Enabled = false;
                        MessageBox.Show("Cliente " + selectedcliente.nome + " foi eliminado", "Cliente Eliminado", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    else if (messageBox.Equals(DialogResult.No) == true)
                    {
                        MessageBox.Show("Cliente " + selectedcliente.nome + " não foi eliminado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Esta função faz com que seja possível editar ou apagar um registo colocando os dados do registo selecionado nos campos
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
            txtnome.Enabled = true;
            comboBox1.Enabled = true;
            masktxtnif.Enabled = true;
            masktxttele.Enabled = true;
        }

        //Fechar Janela
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
            alterarbuton.Enabled = false;
            guardarbutton.Enabled = false;
            txtnome.Enabled = false;
            comboBox1.Enabled = false;
            masktxtnif.Enabled = false;
            masktxttele.Enabled = false;
            txtnome.Clear();
            masktxtnif.Clear();
            masktxttele.Clear();
        }
    }
}