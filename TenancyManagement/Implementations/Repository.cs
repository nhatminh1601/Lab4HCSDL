using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenancyManagement.Interfaces;
using TenancyManagement.Models;

namespace TenancyManagement.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext context;

        public Repository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public IEnumerable<T> Get()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return context.Set<T>().Find(Id);
        }

        public void Remove(int Id)
        {
            var type = context.Set<T>().Find(Id);
            context.Remove(type);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Attach(entity);
        }
    }
}
