using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MagacinskoRobnoMaterijalno.Data;
using MagacinskoRobnoMaterijalno.Data.Model;

namespace MagacinskoRobnoMaterijalno.Data.Repository
{
    public class Repository<T> where T : class
    {
        #region Field        
        /// <summary>
        /// The database context
        /// </summary>
        protected MagacinskoRobnoMaterijalnoDbContext dbContext;
        /// <summary>
        /// The database set
        /// </summary>
        protected readonly DbSet<T> dbSet;
        #endregion

        #region Constructor
        public Repository(MagacinskoRobnoMaterijalnoDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = this.dbContext.Set<T>();

            var objectDbContext = (this.dbContext as IObjectContextAdapter).ObjectContext;
            objectDbContext.CommandTimeout = 2000;
        }
        #endregion

        #region Public methods        
        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.ArgumentNullException">entity</exception>
        public virtual void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            dbSet.Add(entity);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.ArgumentNullException">entity</exception>
        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            if (dbContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }

            dbSet.Remove(entity);
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns></returns>
        public virtual T GetById(params object[] ids)
        {
            return dbSet.Find(ids);
        }
        public virtual List<T> Find(Expression<Func<T, bool>> filter = null,
                                  string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.ToList();
        }

        public virtual async Task<List<T>> FindAsync(Expression<Func<T, bool>> filter = null, string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.ToListAsync();
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose object based on flag value
        /// </summary>
        /// <param name="disposing">Flag that indicates if disposing is in progress</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing &&
                dbContext != null)
            {
                dbContext.Dispose();
                dbContext = null;
            }
        }
        #endregion
    }
}
