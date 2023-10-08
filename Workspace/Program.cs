using Business.Concrete;
using Entities.Concrete;

namespace Workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen = new Citizen();
            citizen.FirstName = "TARIK BERKAY";
            citizen.LastName = "TUNA";
            citizen.BirthYear = 2001;
            citizen.NationalIdentity = 50887451334;

            PttService pttService = new PttService(new CitizenService());
            pttService.GiveMask(citizen);

        }
    }
}