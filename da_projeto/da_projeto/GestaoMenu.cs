using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da_projeto
{
    public partial class GestaoMenu : Form
    {
        public GestaoMenu()
        {
            InitializeComponent();
        }
        //Variável usada para obter o caminho da fotografia
        public string caminhoFoto = "";

        //Carregar dados ao abrir a janela de Gestão de Menu
        private void GestaoMenu_Load(object sender, EventArgs e)
        {
            LerDados();
            txtIngridientes.Enabled = false;
            txtNomeItem.Enabled = false;
            comboBoxAtivo.Enabled = false;
            comboBoxCategoria.Enabled = false;
            txtPreco.Enabled = false;
            btnCarregarFoto.Enabled = false;
            guardarbutton.Enabled = false;
            alterarbuton.Enabled = false;
            apagarbutton.Enabled = false;
            cancelarbutton.Enabled = false;
        }

        //Limpar campos
        private void Limpar()
        {
            txtIngridientes.Clear();
            txtNomeItem.Clear();
            txtPreco.Clear();
            pictureBoxImagem.Image = null;
        }
        //Carregar dados para as listbox e combobox
        private void LerDados()
        {
            comboBoxCategoria.DataSource = MenuPrincipal.restaurante.Categorias.Where(c => c.ativo == true).ToList();
            comboBoxAtivo.DataSource = comboBoxAtivo.Items;
            listBoxRestaurantes.DataSource = MenuPrincipal.restaurante.Restaurantes.ToList<Restaurante>();
            listBoxCategorias.DataSource= MenuPrincipal.restaurante.Categorias.Where(c => c.ativo == true).ToList();
            listBoxCategorias.Enabled = false;
        }

        //Função utilizada para ativar campos para um novo registo de um item de menu
        private void registarbutton_Click(object sender, EventArgs e)
        {
            txtIngridientes.Enabled = true;
            txtNomeItem.Enabled = true;
            comboBoxAtivo.Enabled = true;
            comboBoxCategoria.Enabled = true;
            txtPreco.Enabled = true;
            btnCarregarFoto.Enabled = true;
            guardarbutton.Enabled = true;
            cancelarbutton.Enabled = true;
            Limpar();
        }

        //Carrega a função CarregarFoto()
        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            CarregarFoto();
        }

        //Função que guarda o caminho da imagem e a mostra no ecrã(picturebox)
        private void CarregarFoto()
        {
            //Retirado de https://www.youtube.com/watch?v=GHmC_XKEqXI
            try
            {
                var openFile = new OpenFileDialog();
                //Filtrar dados só para jpg e png
                openFile.Filter = "Arquivos de images jpg e png|*.jpg; *.png";
                //Só se pode selecionar uma imagem por item
                openFile.Multiselect = false;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    caminhoFoto = openFile.FileName;
                }
                if (caminhoFoto != "")
                    pictureBoxImagem.Load(caminhoFoto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Função que guarda a imagem
        private void guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar se os campos estão todos preenchidos
                if (String.IsNullOrEmpty(txtNomeItem.Text) == false && String.IsNullOrEmpty(txtIngridientes.Text) == false &&
                    String.IsNullOrEmpty(txtPreco.Text) == false && String.IsNullOrEmpty(comboBoxCategoria.Text) == false)
                {
                    var listaitens = MenuPrincipal.restaurante.ItemMenus.Select(i => i.nome);
                    //Verificar se já existe um item de menu com o mesmo nome na base de dados
                    if (listaitens.Contains(txtNomeItem.Text))
                    {
                        MessageBox.Show("Item de menu já existente, por favor mude o nome do item!", "Erro criar item menu",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ItemMenu itemmenu = new ItemMenu();
                        itemmenu.nome = txtNomeItem.Text;
                        //Campo usado para obter os bytes da fotografia
                        byte[] foto;
                        //Retirado de https://www.youtube.com/watch?v=GHmC_XKEqXI
                        using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = new BinaryReader(stream))
                            {
                                foto = reader.ReadBytes((int)stream.Length);
                            }
                        }
                        itemmenu.fotografia = foto;
                        itemmenu.CaminhoFoto = caminhoFoto;
                        itemmenu.ingredientes = txtIngridientes.Text;
                        if (int.Parse(txtPreco.Text) > 0)
                        {
                            itemmenu.preco = int.Parse(txtPreco.Text);
                        }
                        itemmenu.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                        if (comboBoxAtivo.SelectedIndex == 0)
                        {
                            itemmenu.ativo = true;
                        }
                        else if (comboBoxAtivo.SelectedIndex == 1)
                        {
                            itemmenu.ativo = false;
                        }
                        //Restaurante Selecionado
                        Restaurante selecionaRestaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
                        //Varíavel auxiliar que guarda o id do restaurante selecionado
                        itemmenu.RestId = selecionaRestaurante.Id;
                        itemmenu.Restaurantes.Add(selecionaRestaurante);
                        MenuPrincipal.restaurante.ItemMenus.Add(itemmenu);
                        MenuPrincipal.restaurante.SaveChanges();
                        LerDados();
                        txtNomeItem.Enabled = false;
                        txtIngridientes.Enabled = false;
                        txtPreco.Enabled = false;
                        comboBoxCategoria.Enabled = false;
                        comboBoxAtivo.Enabled = false;
                        guardarbutton.Enabled = false;
                        cancelarbutton.Enabled = false;
                        Limpar();
                        listBoxMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == selecionaRestaurante.Id).ToList<ItemMenu>();
                    }
                }
                else
                {
                    MessageBox.Show("Os campos são todos obrigatórios", "Erro criar item menu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Função para só permitir escrever números e . na textbox 
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
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

        //Alterar o registo de um item de menu
        private void alterarbuton_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se existe alguma categoria selecionado
                ItemMenu selectedItemmenu = (ItemMenu)listBoxMenu.SelectedItem;
                if (selectedItemmenu == null)
                {
                    return;
                }
                else
                {
                    var guardarlistanomes = MenuPrincipal.restaurante.ItemMenus.Select(i => i.nome);
                    if (String.IsNullOrEmpty(txtNomeItem.Text) == false && String.IsNullOrEmpty(txtIngridientes.Text) == false
                        && String.IsNullOrEmpty(txtPreco.Text) == false)
                    {
                        //Verificar se já existe algum registo com o mesmo nome de item de menu
                        if (guardarlistanomes.Contains(txtNomeItem.Text) && txtNomeItem.Text == selectedItemmenu.nome)
                        {
                            //Atualizar Registo de ItemMenu
                            var itemmenudb = MenuPrincipal.restaurante.ItemMenus.Find(selectedItemmenu.Id);
                            itemmenudb.nome = txtNomeItem.Text;
                            byte[] foto;
                            //Retirado de https://www.youtube.com/watch?v=GHmC_XKEqXI
                            if (String.IsNullOrEmpty(caminhoFoto) == false)
                            {
                                if (itemmenudb.CaminhoFoto != caminhoFoto)
                                {
                                    using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
                                    {
                                        using (var reader = new BinaryReader(stream))
                                        {
                                            foto = reader.ReadBytes((int)stream.Length);
                                        }
                                    }
                                    itemmenudb.fotografia = foto;
                                }
                            }
                            itemmenudb.ingredientes = txtIngridientes.Text;
                            itemmenudb.preco = int.Parse(txtPreco.Text);
                            itemmenudb.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                            if (comboBoxAtivo.SelectedIndex == 0)
                            {
                                itemmenudb.ativo = true;
                            }
                            else if (comboBoxAtivo.SelectedIndex == 1)
                            {
                                itemmenudb.ativo = false;
                            }
                            MenuPrincipal.restaurante.SaveChanges();
                            LerDados();
                            Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
                            listBoxMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == rest.Id).ToList<ItemMenu>();
                            txtIngridientes.Enabled = false;
                            txtNomeItem.Enabled = false;
                            txtPreco.Enabled = false;
                            comboBoxCategoria.Enabled = false;
                            comboBoxAtivo.Enabled = false;
                            btnCarregarFoto.Enabled = false;
                        }
                        else if (guardarlistanomes.Contains(txtNomeItem.Text) == false)
                        {
                            var itemmenudb = MenuPrincipal.restaurante.ItemMenus.Find(selectedItemmenu.Id);
                            itemmenudb.nome = txtNomeItem.Text;
                            byte[] foto;
                            //Retirado de https://www.youtube.com/watch?v=GHmC_XKEqXI
                            if (String.IsNullOrEmpty(caminhoFoto) == false)
                            {
                                if (itemmenudb.CaminhoFoto != caminhoFoto)
                                {
                                    using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
                                    {
                                        using (var reader = new BinaryReader(stream))
                                        {
                                            foto = reader.ReadBytes((int)stream.Length);
                                        }
                                    }
                                    itemmenudb.fotografia = foto;
                                }
                            }
                            itemmenudb.ingredientes = txtIngridientes.Text;
                            itemmenudb.preco = int.Parse(txtPreco.Text);
                            itemmenudb.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                            if (comboBoxAtivo.SelectedIndex == 0)
                            {
                                itemmenudb.ativo = true;
                            }
                            else if (comboBoxAtivo.SelectedIndex == 1)
                            {
                                itemmenudb.ativo = false;
                            }
                            MenuPrincipal.restaurante.SaveChanges();
                            LerDados();
                            Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
                            listBoxMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == rest.Id).ToList<ItemMenu>();
                        }
                        else
                        {
                            MessageBox.Show("Já existe um item de menu com o mesmo nome!", "Erro"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Os campos são todos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Apagar um registo de um item do menu
        private void apagarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar se existe algum item de menu selecionado
                ItemMenu selectedItemMenu = (ItemMenu)listBoxMenu.SelectedItem;
                if (selectedItemMenu == null)
                {
                    return;
                }
                else
                {
                    //Perguntar se o utilizador quer mesmo apagar o registo
                    //Caso a resposta seja igual a sim é eliminado o item de menu é da uma mensagem para informar
                    //Caso a resposta seja não o programa dá uma mensagem a dizer que o item de menu não foi eliminado
                    DialogResult messageBox = MessageBox.Show("Tem a certeza que pretende eliminar o " + selectedItemMenu.nome + "?",
                        "Eliminar registo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBox.Equals(DialogResult.Yes) == true)
                    {
                        //Retirado de https://social.msdn.microsoft.com/Forums/en-US/ea18df09-4c4b-4186-8391-74e9831e4ebd/remove-doesnt-work-with-manytomany-relationship-in-entity-framework-4?forum=aspadoentitylinq
                        var db = MenuPrincipal.restaurante;
                        //
                        var topic = db.ItemMenus.FirstOrDefault(x => x.Id == selectedItemMenu.Id);
                        var subscription = db.Restaurantes.FirstOrDefault(x => x.Id == selectedItemMenu.RestId);
                        topic.Restaurantes.Remove(subscription);
                        db.SaveChanges(); // Flush changes
                        MenuPrincipal.restaurante.ItemMenus.Remove(selectedItemMenu);
                        MenuPrincipal.restaurante.SaveChanges();
                        MessageBox.Show("Item de menu " + selectedItemMenu.nome + " eliminado");
                        LerDados();
                        alterarbuton.Enabled = false;
                        guardarbutton.Enabled = false;
                        cancelarbutton.Enabled = false;
                        apagarbutton.Enabled = false;
                        Limpar();
                        listBoxMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == selectedItemMenu.Id).ToList<ItemMenu>();
                    }
                    else if (messageBox.Equals(DialogResult.No) == true)
                    {
                        MessageBox.Show("Item de menu " + selectedItemMenu.nome + " não foi eliminado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Ativar campos para edição e eliminação de registos
        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemMenu editItemMenu = (ItemMenu)listBoxMenu.SelectedItem;
            if (editItemMenu == null)
            {
                return;
            }
            else
            {
                txtNomeItem.Text = editItemMenu.nome;
                comboBoxAtivo.Text = editItemMenu.GetEstado(editItemMenu.ativo).ToString();
                comboBoxCategoria.Text = editItemMenu.Categoria.ToString();
                txtIngridientes.Text = editItemMenu.ingredientes;
                txtPreco.Text = editItemMenu.preco.ToString();
                txtNomeItem.Enabled = true;
                btnCarregarFoto.Enabled = true;
                pictureBoxImagem.Enabled = true;
                comboBoxAtivo.Enabled = true;
                alterarbuton.Enabled = true;
                apagarbutton.Enabled = true;
                guardarbutton.Enabled = false;
                cancelarbutton.Enabled = false;
                txtIngridientes.Enabled = true;
                txtPreco.Enabled = true;
                pictureBoxImagem.Enabled = true;
                comboBoxCategoria.Enabled = true;
                using (var foto = new MemoryStream(editItemMenu.fotografia))
                {
                    pictureBoxImagem.Image = Image.FromStream(foto);
                }
            }
        }

        //Desativar os campos necessários de um registo de um item de menu
        private void voltarbutton_Click(object sender, EventArgs e)
        {
            txtIngridientes.Enabled = false;
            txtNomeItem.Enabled = false;
            comboBoxAtivo.Enabled = false;
            comboBoxCategoria.Enabled = false;
            txtPreco.Enabled = false;
            btnCarregarFoto.Enabled = false;
            guardarbutton.Enabled = false;
            alterarbuton.Enabled = false;
            apagarbutton.Enabled = false;
            cancelarbutton.Enabled = false;
        }

        //Esconder este ecrã e mostrar ecrã principal
        private void GestaoMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Hide();
        }

        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante rest=(Restaurante)listBoxRestaurantes.SelectedItem;
            listBoxMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == rest.Id).ToList<ItemMenu>();
        }
    }
}
