using Domain.Mobile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Mobile.Entities;
using Domain.Mobile.Repositories;
using RestSharp;

namespace Infraestrutura.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<ItemDoPedido> ItensDoPedido { get { return new Repository<ItemDoPedido>("api/itenspedidos/"); } }
        public IRepository<Lote> Lotes { get { return new Repository<Lote>("api/lotes/"); } }
        public IRepository<Pedido> Pedidos { get { return new Repository<Pedido>("api/pedidos/"); } }
        public IRepository<PontoDeVenda> PontosDeVenda { get { return new Repository<PontoDeVenda>("api/pontodevenda/"); }}
        public IRepository<Produto> Produtos { get { return new Repository<Produto>("api/produtos/"); } }

        private RestClient client; 

        public UnitOfWork(RestClient _client)
        {
            client = _client;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Concluir(RestRequest request)
        {
            client.Execute(request);
        }
    }
}
