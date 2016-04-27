using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class Pedido
    {

        public int Id { get; set; }
        public int PontoId { get; set; }
        public DateTime DataPedido { get; set; }

        public virtual PontoDeVenda PontoDeVenda { get; set; }
        public virtual List<ItemDoPedido> ItensDoPedidos { get; set; }

        private Pedido()
        {
            ItensDoPedidos = new List<ItemDoPedido>();
        }

        public Pedido(PontoDeVenda pontoDeVenda, DateTime dataPedido)
        {
            this.PontoDeVenda = pontoDeVenda;
            this.PontoId = pontoDeVenda.Id;
            this.DataPedido = dataPedido;
            ItensDoPedidos = new List<ItemDoPedido>();
        }

    }
}
