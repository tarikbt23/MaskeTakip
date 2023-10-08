using Business.Abstratct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttService : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttService(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Citizen citizen)
        {
            //*CitizenService citizenService = new CitizenService();* bu kod CitizenService
            //classına bagimlilik olusturmakta. Yabancılara da maske verilebilmesi icin
            //interface kullandim. interface hem citizen hem de foreigner referansi tutuyor.

            if (_applicantService.CheckCitizen(citizen) == true)
            {
                Console.WriteLine(citizen.FirstName + " " + citizen.LastName + " icin maske verildi.");
            }
            else
            {
                Console.WriteLine(citizen.FirstName + " " +  citizen.LastName  + " icin maske verilemedi.");
            }
        }
    }
}
