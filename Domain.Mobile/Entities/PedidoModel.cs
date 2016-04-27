using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class PedidoModel
    {
        public PontoDeVenda Ponto { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataPedido { get; set; }
        public int Quantidade { get; set; }
        public int PrazoValidadeParaVenda { get; set; }

        public PedidoModel(PontoDeVenda ponto, Produto produto, DateTime dataPedido, int quantidade, int PrazoValidadeParaVenda)
        {
            this.Ponto = ponto;
            this.Produto = produto;
            this.DataPedido = dataPedido;
            this.Quantidade = quantidade;
            this.PrazoValidadeParaVenda = PrazoValidadeParaVenda;
        }
    }
}
