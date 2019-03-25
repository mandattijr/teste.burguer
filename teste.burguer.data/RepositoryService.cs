using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace teste.burguer.data
{
    public class RepositoryService<TEntity> where TEntity : class
    {
        private DbContext Context;
        private string erro = string.Empty;
        private string erros = string.Empty;
        private DataContext dbContext;


        private IDbSet<TEntity> Entities
        {
            get { return this.Context.Set<TEntity>(); }
        }

        public RepositoryService(DataContext dbContext)
        {
            // TODO: Complete member initialization
            this.dbContext = dbContext;
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate) {
            try {

                IQueryable<TEntity> query = Entities;
                return query.Where(predicate).AsQueryable<TEntity>();

            }
            catch (DbEntityValidationException e) {
                foreach (var eve in e.EntityValidationErrors) {
                    erro = "Erros de vaidação na consulta: ";
                    foreach (var ve in eve.ValidationErrors) {
                        erros = string.Concat(erros, string.Format("- Propriedade: \"{0}\", Erro: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }

                throw new Exception(string.Concat(erro, erros));
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public IQueryable<TEntity> FilterOrder(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> order)
        {

            IQueryable<TEntity> query = Entities;

            return query.Where(predicate).OrderBy(order).AsQueryable<TEntity>();

        }

        public IQueryable<TEntity> FilterInclude(Expression<Func<TEntity, bool>> predicate, List<string> includes)
        {
            try {
                IQueryable<TEntity> query = Entities;
                includes.ForEach(x => query = query.Include(x));
                return query.Where(predicate).AsQueryable<TEntity>();
            }
            catch (DbEntityValidationException e) {
                foreach (var eve in e.EntityValidationErrors) {
                    erro = "Erros de vaidação na consulta com include: ";
                    foreach (var ve in eve.ValidationErrors) {
                        erros = string.Concat(erros, string.Format("- Propriedade: \"{0}\", Erro: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }

                throw new Exception(string.Concat(erro, erros));
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public IQueryable<TEntity> FilterOrderInclude(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> order, List<string> includes)
        {

            IQueryable<TEntity> query = Entities;

            includes.ForEach(x => query = query.Include(x));

            return query.Where(predicate).OrderBy(order).AsQueryable<TEntity>();

        }

        public IQueryable<TEntity> FilterPaginacao(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> order, int pages, int page, List<string> includes)
        {

            IQueryable<TEntity> query = Entities;

            includes.ForEach(x => query = query.Include(x));
            var retorno = query.Where(predicate).OrderBy(order).AsQueryable<TEntity>().Skip(pages).Take(page);
            return retorno;

        }

        public IQueryable<TEntity> FilterPaginacao(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> order, int pages, int page)
        {

            IQueryable<TEntity> query = Entities;

            var retorno = query.Where(predicate).OrderBy(order).AsQueryable<TEntity>().Skip(pages).Take(page);
            return retorno;

        }

        public TEntity Insert(TEntity entity)
        {
            try
            {
                Entities.Add(entity);
                this.Context.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    erro = "Erros de vaidação na inclusão: ";
                    foreach (var ve in eve.ValidationErrors)
                    {
                        erros = string.Concat(erros, string.Format("- Propriedade: \"{0}\", Erro: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }

                throw new Exception(string.Concat(erro, erros));
            }
            catch (Exception ex) {
                throw ex;
            }

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            try {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                this.Context.SaveChanges();

            }
            catch (DbEntityValidationException e) {
                foreach (var eve in e.EntityValidationErrors) {
                    erro = "Erros de vaidação na exclusão: ";
                    foreach (var ve in eve.ValidationErrors) {
                        erros = string.Concat(erros, string.Format("- Propriedade: \"{0}\", Erro: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }

                throw new Exception(string.Concat(erro, erros));
            }
            catch (Exception ex) {
                throw ex;
            }
            return entity;
        }

        public void Delete(TEntity entity) {
            Entities.Remove(entity);
            this.Context.SaveChanges();
        }

        public void DeleteAll(List<TEntity> entity) {
            entity.ForEach(x=> Entities.Remove(x));
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Context != null)
                {
                    this.Context.Dispose();
                    this.Context = null;
                }
            }
        }
    }
}
