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
            gpPedidos.Enabled = false;
        }
        private void LerDados()
        {
            listBoxRestaurantes.DataSource = MenuPrincipal.restaurante.Restaurantes.ToList<Restaurante>();
            listBoxCliente.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Cliente>().ToList();
            listBoxMetodosPagamentos.DataSource = MenuPrincipal.restaurante.MetodoPagamentoes.ToList<MetodoPagamento>();
        }
        private void LerDadosPedidos()
        {
            Restaurante rest = (Restaurante)listBoxRestaurantes.SelectedItem;
            listBoxPedido.DataSource = MenuPrincipal.restaurante.Pedidoes.Where(p => p.RestauranteId == rest.Id && p.EstadoId==1).ToList<Pedido>();
            listBoxTrabalhador.DataSource = MenuPrincipal.restaurante.Pessoas.OfType<Trabalhador>()
                .Where(t => t.RestauranteId == rest.Id).ToList<Trabalhador>();
            listBoxPedidosProc.DataSource = MenuPrincipal.restaurante.Pedidoes.Where(p => p.RestauranteId == rest.Id && p.EstadoId == 2).ToList<Pedido>();
            listBoxPedidosConcluidos.DataSource = MenuPrincipal.restaurante.Pedidoes.Where(p =>p.RestauranteId==rest.Id && p.EstadoId == 4).ToList<Pedido>();
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
                    gpPedidos.Enabled = false;
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
            Pedido pedido = (Pedido)listBoxPedido.SelectedItem;
            listBoxItemSelecionado.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.PedidoId == pedido.Id).ToList<ItemMenu>();
            comboBoxEstado.DataSource = MenuPrincipal.restaurante.Estadoes.Where(i=>i.Id==2 || i.Id==3).ToList<Estado>();
            gpPedidos.Enabled = true;
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
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
                var itemmenu = MenuPrincipal.restaurante.ItemMenus.Find(selectitem.Id);
                itemmenu.PedidoId = selectpedido.Id;
                pedidoitem.valortotal = pedidoitem.valortotal + itemmenu.preco;
                MenuPrincipal.restaurante.SaveChanges();
                LerDadosPedidoItem();
            }
        }
        private void LerDadosPedidoItem()
        {
            Pedido selectpedido = (Pedido)listBoxPedido.SelectedItem;
            listBoxItemSelecionado.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.PedidoId == selectpedido.Id).ToList();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            try
            {
                ItemMenu selectedItemMenu = (ItemMenu)listBoxItemSelecionado.SelectedItem;
                Pedido selectedPedido=(Pedido)listBoxPedido.SelectedItem;
                //Retirado de https://social.msdn.microsoft.com/Forums/en-US/ea18df09-4c4b-4186-8391-74e9831e4ebd/remove-doesnt-work-with-manytomany-relationship-in-entity-framework-4?forum=aspadoentitylinq
                var db = MenuPrincipal.restaurante;
                //
                var item = db.ItemMenus.FirstOrDefault(x => x.Id == selectedItemMenu.Id);
                var rest = db.Restaurantes.FirstOrDefault(x => x.Id == selectedItemMenu.RestId);
                var ped = db.Pedidoes.FirstOrDefault(x => x.Id == selectedItemMenu.PedidoId);
                item.Restaurantes.Remove(rest);
                item.Pedidoes.Remove(ped);
                MenuPrincipal.restaurante.ItemMenus.Remove(selectedItemMenu);
                MenuPrincipal.restaurante.SaveChanges();
                listBoxItemSelecionado.DataSource = MenuPrincipal.restaurante.ItemMenus.Where(i => i.PedidoId == selectedPedido.Id).ToList<ItemMenu>();
            }
            catch(Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
}

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido selectpedido = (Pedido)listBoxPedido.SelectedItem;
                if (selectpedido == null)
                {
                    MessageBox.Show("Selecione um pedido");
                }
                else
                {
                    Estado estado = (Estado)comboBoxEstado.SelectedItem;
                    var updateestado = MenuPrincipal.restaurante.Pedidoes.Find(selectpedido.Id);
                    updateestado.EstadoId = estado.Id;
                    updateestado.faltapagar = updateestado.valortotal;
                    MenuPrincipal.restaurante.SaveChanges();
                    LerDados();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedidoproc = (Pedido)listBoxPedidosProc.SelectedItem;
                MetodoPagamento metodopaga = (MetodoPagamento)listBoxMetodosPagamentos.SelectedItem;
                Pagamento paga = new Pagamento();
                if (pedidoproc.faltapagar >= numericUpDown1.Value)
                {
                    paga.MetodoPagamento = metodopaga;
                    paga.MetodoPagamentoId = metodopaga.Id;
                    paga.valor = numericUpDown1.Value;
                    paga.PedidoId = pedidoproc.Id;
                    paga.Pedido = pedidoproc;
                    pedidoproc.faltapagar = pedidoproc.faltapagar - numericUpDown1.Value;
                    if (pedidoproc.faltapagar == 0)
                    {
                        pedidoproc.EstadoId = 4;
                    }
                    pedidoproc.Cliente.totalgasto=pedidoproc.Cliente.totalgasto +numericUpDown1.Value;
                    MenuPrincipal.restaurante.Pagamentoes.Add(paga);
                    MenuPrincipal.restaurante.SaveChanges();
                    LerDadosPedidos();
                    numericUpDown1.Value = 0;
                    labelfaltapagar.Text = "0";
                }
                else
                {
                    MessageBox.Show("Falta pagar exatamente", pedidoproc.faltapagar + "€");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxPedidosProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pedido pedidoproc = (Pedido)listBoxPedidosProc.SelectedItem;
            numericUpDown1.Maximum = pedidoproc.faltapagar;
            labelfaltapagar.Text = pedidoproc.faltapagar.ToString();
        }

        private void btnExportartxt_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBoxPedidosConcluidos.SelectedItem;
            if (pedido == null)
            {
                MessageBox.Show("Não selecionou nenhum pedido concluido","Erro exportar txt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string nomeFicheiro = pedido.Id + "_" + pedido.Cliente.nome + ".txt";
                FileStream fs = new FileStream(nomeFicheiro, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("Número do pedido: "+pedido.Id + "(Cliente: " + pedido.Cliente.nome + " Nif: "+pedido.Cliente.numcontribuinte+")");
                sw.WriteLine("____________________________________________");
                sw.WriteLine("Linhas Pedido");
                foreach (var items in pedido.ItemMenus)
                {
                    sw.WriteLine(items.nome+" Valor:"+items.preco+"€");
                }
                sw.WriteLine("____________________________________________");
                sw.WriteLine("Total do Pedido: " + pedido.valortotal + "€");
                sw.WriteLine("____________________________________________");
                sw.WriteLine("Pagamentos");
                foreach(var pagamentos in pedido.Pagamentoes)
                {
                    sw.WriteLine("Valor: "+pagamentos.valor+"€  Método Pagamento: "+pagamentos.MetodoPagamento);
                }
                sw.Close();
                fs.Close();
            }
        }
    }
}
