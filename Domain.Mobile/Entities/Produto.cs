using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class Produto
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public int DiasValidos { get; set; }
        public decimal Preco { get; set; }
        //public int PrazoValidade { get; set; }
        //public decimal PrecoVenda { get; set; }

        public virtual List<Lote> Lotes { get; set; }
        public virtual List<HistoricoPrecoVenda> HistoricosPrecoVenda { get; set; }
        public virtual List<ItemDoPedido> ItensDoPedido { get; set; }

        private Produto()
        {

        }

        public Produto(string nome, int prazoValidade, decimal precoVenda)
        {
            this.Nome = nome;
            this.DiasValidos = prazoValidade;
            this.Preco = precoVenda;
        }
        
    }
}
