using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Citizen citizen);
        List<Citizen> GetList();
        bool CheckCitizen(Citizen citizen);
    }
}
