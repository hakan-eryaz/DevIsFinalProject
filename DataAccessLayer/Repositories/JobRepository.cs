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
    public class JobRepository: IJobDal
    {
        Context _context;
        public List<Job> ListAllJob()
        {
            return _context.Jobs.ToList();
        }

        public void AddJob(Job job)
        {
            _context.Add(job);
            _context.SaveChanges();
        }

        public void RemoveJob(Job job)
        {
            _context.Remove(job);
            _context.SaveChanges();
        }

        public void UpdateJob(Job job)
        {
            _context.Update(job);
            _context.SaveChanges();
        }

        public Job GetJob(int id)
        {
            return _context.Jobs.Find(id);
        }

        public void Add(Job entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Job entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Job entity)
        {
            throw new NotImplementedException();
        }

        public List<Job> GetAll()
        {
            throw new NotImplementedException();
        }

        public Job Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
