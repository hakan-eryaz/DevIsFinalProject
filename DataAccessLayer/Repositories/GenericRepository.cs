using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T>:IGenericDal<T> where T: class
    {
        public void Add(T entity)
        {
            using var context = new Context();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            using var context = new Context();
            context.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new Context();
            context.Update(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using var context = new Context();

            return context.Set<T>().Where(filter).ToList();
        }
    }
}
