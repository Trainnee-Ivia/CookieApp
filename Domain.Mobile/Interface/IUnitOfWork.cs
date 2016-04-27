using Domain;
using Domain.Mobile.Entities;
using Domain.Mobile.Interface;
using Domain.Mobile.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Produto> Produtos { get; }
        IRepository<Lote> Lotes { get; }
        IRepository<Pedido> Pedidos { get; }
        IRepository<PontoDeVenda> PontosDeVenda { get; }
        IRepository<ItemDoPedido> ItensDoPedido { get; }

        int Save();
    }
}
