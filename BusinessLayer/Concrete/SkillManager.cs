using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        private ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal=skillDal;
        }
        public List<Skill> GetAll()
        {
            return _skillDal.GetAll();
        }

        public Skill GetById(int id)
        {
            return _skillDal.Get(id);
        }

        public void TAdd(Skill entity)
        {
            _skillDal.Add(entity);
        }

        public void TRemove(Skill entity)
        {
            _skillDal.Remove(entity);
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
