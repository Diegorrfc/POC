using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Trigre.Repository
                
{
    public interface IRepository<T> where T : class
    {
        
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Procurar(params object[] key);
        T Primeiro(Expression<Func<T, bool>> predicate);
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Deletar(Func<T, bool> predicate);

    
    }
}
