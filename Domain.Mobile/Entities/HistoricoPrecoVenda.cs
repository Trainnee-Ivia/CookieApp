using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class HistoricoPrecoVenda
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public DateTime Data { get; set; }
        public decimal PrecoVenda { get; set; }

        public virtual Produto Produto { get; set; }

        private HistoricoPrecoVenda()
        {

        }

        public HistoricoPrecoVenda(Produto produto, DateTime data, decimal precoVenda)
        {
            this.Produto = produto;
            this.ProdutoId = produto.Id;
            this.Data = data;
            this.PrecoVenda = precoVenda;
        }

    }
}
