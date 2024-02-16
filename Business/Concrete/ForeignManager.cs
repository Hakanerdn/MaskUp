using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ForeignManager : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public bool CheckCitizen(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public List<Citizen> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
