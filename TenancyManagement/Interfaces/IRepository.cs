using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenancyManagement.Interfaces
{
    interface IRepository<T> where T : class
    {
        void Add(T entity);
        T GetById(int Id);
        IEnumerable<T> Get();
        void Remove(int Id);
        void Save();
        void Update(T entity);
    }
}
