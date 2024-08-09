using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Business.Shared.Abstract
{
    public interface IBaseService<T>
    {
        Task<IEnumerable<T>> GetAllAsync(); //Tüm nesneleri getirir.
        Task<T> GetByIdAsync(int id); //Belirli bir nesneyi getirir.
        Task AddAsync(T entity); //Yeni bir nesneyi ekler.
        Task UpdateAsync(T entity); //Var olan bir nesneyi günceller
        Task DeleteAsync(int id); //Belirli bir nesneyi siler.
    }
}
