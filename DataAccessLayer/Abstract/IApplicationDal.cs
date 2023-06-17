using EntityLayer.Concrete;


namespace DataAccessLayer.Abstract
{
    public interface IApplicationDal:IGenericDal<Application>
    {
        List<ApplicationViewModel> GetApplications();
    }
}
