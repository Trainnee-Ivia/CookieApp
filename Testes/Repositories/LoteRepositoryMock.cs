using Domain.Mobile.Entities;
using Domain.Mobile.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Repositories
{
    public class LoteRepositoryMock : RepositoryMock<Lote>, ILoteRepository
    {
        public List<Lote> lotes { get; set; }

        public LoteRepositoryMock()
        {
            lotes.AddRange(new List<Lote>()
            {
                new Lote(new Produto("Chocolate", 15, 2m), DateTime.Now, 10),
                new Lote(new Produto("Morango", 13, 2.5m), DateTime.Now.AddDays(-2), 5)
            });
        }

        public IEnumerable<Lote> GetLotesValidos(int produtoId, DateTime dataPedido, double controle)
        {
            var data = dataPedido.AddDays(controle);

            return lotes.Where(x => data.CompareTo(x.DataVencimento) <= 0
                && x.ProdutoId == produtoId);
        }

       
    }
}
