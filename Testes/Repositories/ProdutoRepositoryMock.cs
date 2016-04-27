using Domain.Mobile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Repositories
{
    public class ProdutoRepositoryMock : RepositoryMock<Produto>
    {
        public List<Produto> produtos { get; set; }

        public ProdutoRepositoryMock()
        {
            produtos = collectionTEntity;
            produtos.AddRange(new List<Produto>()
            {
                new Produto("Tradicional", 18, 2m),
                new Produto("Chocolate", 15, 2m),
                new Produto("Morango", 13, 2.5m)
            });
        }
    }
}
