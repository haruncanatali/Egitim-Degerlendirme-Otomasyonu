using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Egitim.Business.Abstract
{
    public interface IServiceRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> List(Expression<Func<TEntity, bool>> filter=null);
    }
}
