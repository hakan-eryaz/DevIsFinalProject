using EntityLayer.Concrete;
using EntityLayer.Concrete.ViewModels;

namespace DataAccessLayer.Abstract
{
    public interface IApplicationDal:IGenericDal<Application>
    {
        List<ApplicationViewModel> GetApplications();
        ApplicationViewModel GetApplicationsByID(int id);
    }
}
