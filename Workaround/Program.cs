using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen1 = new Citizen();
            citizen1.FirstName = "Gözde";
            citizen1.LastName = "Mutlugün";
            citizen1.DateOfBirthYear = 2002;
            citizen1.NationalIdentity = 123;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(citizen1);


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
