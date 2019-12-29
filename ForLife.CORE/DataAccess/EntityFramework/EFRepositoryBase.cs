﻿using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.CORE.DataAccess.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        TContext tContext;
        //private DbSet<TEntity> _dbSet;
        //TODO//change
        public EFRepositoryBase(TContext dbContext)
        {
            tContext = dbContext;
          //  _dbSet = tContext.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            tContext.Entry(entity).State = EntityState.Added;
        }

        public void Delete(TEntity entity)
        {
            tContext.Entry(entity).State = EntityState.Deleted;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return tContext.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter==null)
            {
                return tContext.Set<TEntity>().ToList();
            }
            else
            {
                return tContext.Set<TEntity>().Where(filter).ToList();
            }
           
        }

        public void Update(TEntity entity)
        {
            tContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
