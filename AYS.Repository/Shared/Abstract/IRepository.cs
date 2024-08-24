using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Repository.Shared.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); 
        T GetById(int id);
        T Add(T entity);
        List<T> AddRange(List<T> entities); //birden fazla entities alan lisste şeklinde dönen 
        T Update(T entity);
        void Delete(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);   
        void Save();
    }

}
