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
        //Variável para obter o caminho da fotografia
        public string caminhoFoto = "";
        private void GestaoMenu_Load(object sender, EventArgs e)
        {
            LerDados();
        }
        private void LerDados()
        {
            comboBoxCategoria.DataSource = MenuPrincipal.restaurante.Categorias.ToList();
            listBoxMenu.DataSource=MenuPrincipal.restaurante.ItemMenus.ToList();
        }
        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            CarregarFoto();
        }
        private void CarregarFoto()
        {
            //Tirado de https://www.youtube.com/watch?v=GHmC_XKEqXI
            try
            {
                var openFile = new OpenFileDialog();
                openFile.Filter = "Arquivos de images jpg e png|*.jpg; *.png";
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

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if ()
                {
                    ItemMenu itemmenu = new ItemMenu();
                    itemmenu.nome = txtNomeItem.Text;
                    byte[] foto;
                    //Tirado de https://www.youtube.com/watch?v=GHmC_XKEqXI
                    using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {
                            foto = reader.ReadBytes((int)stream.Length);
                        }
                    }
                    itemmenu.fotografia = foto;
                    itemmenu.ingredientes = txtIngridientes.Text;
                    if (int.Parse(txtPreco.Text) > 0)
                    {
                        itemmenu.preco = int.Parse(txtPreco.Text);
                    }
                    itemmenu.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                    itemmenu.ativo = true;

                    MenuPrincipal.restaurante.ItemMenus.Add(itemmenu);
                    MenuPrincipal.restaurante.SaveChanges();
                    LerDados();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
