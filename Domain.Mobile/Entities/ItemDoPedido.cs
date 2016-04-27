using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class ItemDoPedido
    {
        
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade{ get; set; }
        public decimal PrecoVendaUnitaria { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual List<HistoricoDeLote> HistoricosDeLote { get; set; }
        
        private ItemDoPedido()
        {
            HistoricosDeLote = new List<HistoricoDeLote>();
        }

        public ItemDoPedido(Produto produto, Pedido pedido, int quantidade, decimal precoVendaUnitario)
        {
            this.Produto = produto;
            this.ProdutoId = produto.Id;
            this.Pedido = pedido;
            this.PedidoId = pedido.Id;
            this.Quantidade = quantidade;
            this.PrecoVendaUnitaria = precoVendaUnitario;
            HistoricosDeLote = new List<HistoricoDeLote>();
        }

    }
}
