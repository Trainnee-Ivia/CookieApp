using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class HistoricoDeLote
    {
        public int Id { get; set; }
        public int ItemPedidoId { get; set; }
        public int LoteId { get; set; }
        public int Quantidade { get; set; }

        public virtual ItemDoPedido ItemPedido { get; set; }
        public virtual Lote Lote { get; set; }

        private HistoricoDeLote()
        {

        }

        public HistoricoDeLote(ItemDoPedido itemPedido, Lote lote, int quantidade)
        {
            this.ItemPedido = itemPedido;
            this.ItemPedidoId = itemPedido.Id;
            this.Lote = lote;
            this.LoteId = lote.Id;
            this.Quantidade = quantidade;
        }

    }
}
