using MagacinskoRobnoMaterijalno.Data.Model;
using MagacinskoRobnoMaterijalno.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Data.UnitOfWork
{
    public class UOW : IDisposable
    {
        #region Private fields
        private bool disposed = false;
        private MagacinskoRobnoMaterijalnoDbContext context;
        private readonly string _connectionString;
        private readonly DbContextTransaction transaction;
        #endregion
        #region Constructor
        public UOW(string connectionstring = null, bool useTransaction = false)
        {
            _connectionString = connectionstring;
            if (useTransaction)
            {
                transaction = DataContext.Database.BeginTransaction();
            }

        }
        #endregion
        #region Properties
        public MagacinskoRobnoMaterijalnoDbContext DataContext => context ?? (!string.IsNullOrEmpty(_connectionString) ? context = new MagacinskoRobnoMaterijalnoDbContext(_connectionString) : context = new MagacinskoRobnoMaterijalnoDbContext());

        public DbContextTransaction Transaction
        {
            get
            {
                if (transaction == null)
                {
                    throw new ArgumentNullException("DataContext does not exist!");
                }
                else
                {
                    return transaction;
                }
            }
        }
        #endregion

        #region Properties of repository

        #region Article repository
        private Repository<Article> articleRepository;
        public Repository<Article> ArticleRepository => articleRepository ?? (articleRepository = new Repository<Article>(DataContext));
        #endregion

        #region Client repository
        private Repository<Client> clientRepository;
        public Repository<Client> ClientRepository => clientRepository ?? (clientRepository = new Repository<Client>(DataContext));
        #endregion

        #region Document repository
        private Repository<Document> documentRepository;
        public DocumentRepository DocumentRepository => (DocumentRepository) (documentRepository ?? (documentRepository = new DocumentRepository(DataContext)));
        #endregion

        #region DocumentItem repository
        private Repository<DocumentItem> documentItemRepository;
        public Repository<DocumentItem> DocumentItemRepository => documentItemRepository ?? (documentItemRepository = new Repository<DocumentItem>(DataContext));
        #endregion

        #region Warehouse repository
        private Repository<Warehouse> warehouseRepository;
        public Repository<Warehouse> WarehouseRepository => warehouseRepository ?? (warehouseRepository = new Repository<Warehouse>(DataContext));
        #endregion

        #endregion

        #region Public methods        
        /// <summary>
        /// Saves the asynchronous.
        /// </summary>
        public async Task SaveAsync()
        {
            context.ChangeTracker.DetectChanges();
            await context.SaveChangesAsync();
        }

        public int Save()
        {
           context.ChangeTracker.DetectChanges();
           return context.SaveChanges();
        }
        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            transaction.Commit();
        }
        /// <summary>
        /// Rolls the back.
        /// </summary>
        public void RollBack()
        {
            transaction.Rollback();
        }
        #endregion
        #region Dispose
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context?.Dispose();
                }
            }
            this.disposed = true;
        }

        public bool IsChangedChanged()
        {
            return context.ChangeTracker.Entries().Any(e => e.State == EntityState.Added
                                          || e.State == EntityState.Modified
                                          || e.State == EntityState.Deleted);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
