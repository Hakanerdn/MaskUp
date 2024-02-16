using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {

        }

        public bool CheckCitizen(Citizen citizen)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(citizen.NationalIdentity, citizen.FirstName, citizen.LastName, citizen.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Citizen> GetList()
        {
            return null;
        }
    }
}
