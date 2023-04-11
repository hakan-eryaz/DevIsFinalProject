using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class ApplicationRepository: IApplicationDal
    {
        public List<Application> ListAllApplication()
        {
            using var context = new Context();
            return context.Applications.ToList();
        }

        public void AddApplication(Application application)
        {
            using var context = new Context();
            context.Add(application);
            context.SaveChanges();
        }

        public void RemoveApplication(Application application)
        {
            using var context = new Context();
            context.Remove(application);
            context.SaveChanges();
        }

        public void UpdateApplication(Application application)
        {
            using var context = new Context();
            context.Update(application);
            context.SaveChanges();
        }

        public Application GetApplication(int id)
        {
            using var context = new Context();
            return context.Applications.Find(id);
        }

        public void Add(Application entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Application entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Application entity)
        {
            throw new NotImplementedException();
        }

        public List<Application> GetAll()
        {
            throw new NotImplementedException();
        }

        public Application Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
