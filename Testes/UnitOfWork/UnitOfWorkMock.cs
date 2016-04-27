using Domain.Mobile.Entities;
using Domain.Mobile.Interface;
using Domain.Mobile.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes.Repositories;

namespace Testes.UnitOfWork
{
    public class UnitOfWorkMock : IUnitOfWork
    {
        public IRepository<ItemDoPedido> ItensDoPedido { get; private set; }
        public ILoteRepository Lotes { get; private set; }
        public IRepository<Pedido> Pedidos { get; private set; }
        public IRepository<PontoDeVenda> PontosDeVenda { get; private set; }
        public IRepository<Produto> Produtos { get; private set; }

        public UnitOfWorkMock()
        {
            Produtos = new RepositoryMock<Produto>();
            Lotes = new LoteRepositoryMock();
            Pedidos = new RepositoryMock<Pedido>();
            PontosDeVenda = new RepositoryMock<PontoDeVenda>();
            ItensDoPedido = new RepositoryMock<ItemDoPedido>();

        }

        public void Dispose()
        {
            
        }

        public int Save()
        {
            return 1;
        }
    }
}
