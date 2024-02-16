using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Citizen citizen)
        {
            if (_applicantService.CheckCitizen(citizen))
            {
                Console.WriteLine(citizen.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(citizen.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
