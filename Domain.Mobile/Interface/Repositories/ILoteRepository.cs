using Domain.Mobile.Entities;
using Domain.Mobile.Interface;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Domain.Mobile.Repositories
{
    public interface ILoteRepository : IRepository<Lote>
    {
        IEnumerable<Lote> GetLotesValidos(int produtoId, DateTime dataPedido, double controle);

    }
}