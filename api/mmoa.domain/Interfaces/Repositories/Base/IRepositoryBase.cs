using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace mmoa.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity, Tid>
        where TEntity: class
        where Tid: struct
    {
        IQueryable<TEntity> ListBy(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> ListAndOrderBy<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order, bool ascendente = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetBy(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties);

        bool Exists(Func<TEntity, bool> where);

        IQueryable<TEntity> List(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> ListOrderBy<TKey>(Expression<Func<TEntity, TKey>> order, bool ascendente = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetById(Tid id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity Add(TEntity entity);

        TEntity Edit(TEntity entity);

        void Delete(TEntity entity);

        void DeleteList(IEnumerable<TEntity> entities);

        void AddList(IEnumerable<TEntity> entities);
    }
}
