using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class Lote
    {

        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public int Quantidade { get; set; }
        public decimal CustoUnitario { get; set; }
        public int SaldoProduto { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual ICollection<HistoricoDeLote> HistoricoDeLotes { get; set; }


        private Lote()
        {

        }

        public Lote(Produto Produto, DateTime DataFabricacao, int Quantidade)
        {
            this.Produto = Produto;
            this.ProdutoId = Produto.Id;
            this.DataFabricacao = DataFabricacao;
            this.DataVencimento = this.DataFabricacao.AddDays(this.Produto.DiasValidos);
            this.Quantidade = Quantidade;
            this.CustoUnitario = this.Produto.Preco;
            this.SaldoProduto = this.Quantidade;
        }
    }
}
