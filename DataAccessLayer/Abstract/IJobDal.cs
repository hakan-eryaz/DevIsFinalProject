﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using EntityLayer.Concrete.ViewModels;

namespace DataAccessLayer.Abstract
{
    public interface IJobDal:IGenericDal<Job>
    {
        List<Job> GetListWithCategory();
        DetailedJobViewModel GetAllInfoAboutJob(int id);
    }
}
