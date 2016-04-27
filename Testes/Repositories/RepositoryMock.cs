using Domain.Mobile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Domain.Mobile.Interface;

namespace Testes.Repositories
{
    public class RepositoryMock<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public List<TEntity> collectionTEntity { get; set; }

        public RepositoryMock()
        {
            collectionTEntity = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            collectionTEntity.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            collectionTEntity.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return collectionTEntity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return collectionTEntity;
        }

        public TEntity GetSingle(int id)
        {
            return collectionTEntity.FirstOrDefault();
        }

        public void Remove(TEntity entity)
        {
            collectionTEntity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            //collectionTEntity.ToList().RemoveRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
