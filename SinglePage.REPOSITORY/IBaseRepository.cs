using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglePage.ORM.Data;

namespace SinglePage.REPOSITORY
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        int Update(T entity);
        void Delete(T entity);
        bool DeletebyEntity(Func<T, bool> entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetbyEntity(Func<T, bool> entity);
    }
}
