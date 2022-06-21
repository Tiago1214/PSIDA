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
    public partial class GestaoPedidos : Form
    {
        public GestaoPedidos()
        {
            InitializeComponent();
        }

        private void GestaoPedidos_Load(object sender, EventArgs e)
        {
            LerDados();
            gpPedidos.Enabled = false;
        }
        private void LerDados()
        {
            listBoxRestaurantes.DataSource = MenuPrincipal.restaurante.Restaurantes.ToList<Restaurante>();
            listBoxCliente.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Cliente>().ToList();
        }
        private void LerDadosPedidos()
        {
            Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
            listBoxPedido.DataSource = MenuPrincipal.restaurante.Pedidoes.Where(p => p.RestauranteId == rest.Id).ToList<Pedido>();
            listBoxTrabalhador.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Trabalhador>()
                .Where(t => t.RestauranteId == rest.Id).ToList<Trabalhador>();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            gpPedidos.Enabled = true;
            
        }

        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
                Cliente cliente=(Cliente)listBoxCliente.SelectedItem;
                Trabalhador trabalhador = (Trabalhador)listBoxTrabalhador.SelectedItem;
                if (restaurante == null||cliente==null||trabalhador==null)
                {
                    MessageBox.Show("Tem de selecionar um restaurante, trabalhador e cliente para criar um pedido", "Erro criar Pedido", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Pedido pedido = new Pedido();
                    pedido.valortotal = 0;
                    pedido.Trabalhador = trabalhador;
                    pedido.Cliente = cliente;
                    pedido.Restaurante = restaurante;
                    pedido.RestauranteId = restaurante.Id;
                    pedido.TrabalhadorId = trabalhador.Id;
                    pedido.ClienteId = cliente.Id;
                    //Quando se cria um pedido fica em recebido
                    pedido.EstadoId = 1;
                    MenuPrincipal.restaurante.Pedidoes.Add(pedido);
                    MenuPrincipal.restaurante.SaveChanges();
                    LerDadosPedidos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerDadosPedidos();
        }

        private void listBoxPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
            listBoxItemMenu.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.RestId == rest.Id).ToList<ItemMenu>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido selectpedido = (Pedido)listBoxPedido.SelectedItem;
            ItemMenu selectitem = (ItemMenu)listBoxItemMenu.SelectedItem;
            if (selectpedido == null||selectitem==null)
            {
                MessageBox.Show("Não existe nenhum pedido selecionado");
            }
            else
            {
                var pedidoitem = MenuPrincipal.restaurante.Pedidoes.Find(selectpedido.Id);
                pedidoitem.ItemMenus.Add(selectitem);
                MenuPrincipal.restaurante.SaveChanges();
                LerDadosPedidoItem();
            }
        }
        private void LerDadosPedidoItem()
        {
            Pedido selectpedido = (Pedido)listBoxPedido.SelectedItem;
            listBoxItemSelecionado.DataSource = MenuPrincipal.restaurante.Pedidoes.OfType<ItemMenu>().Where(i =>  i.Pedidoes== selectpedido);
        }
    }
}
