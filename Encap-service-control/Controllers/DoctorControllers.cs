using Encap_service_control.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap_service_control.Controllers
{
    internal class DoctorControllers
    {
        public void GetFilterByAge()
        {
            DoctorService doctorService = new DoctorService();

            DateTime startAge = new(1993,05,25);
            DateTime endAge = new(2002,12,15);

            var result = doctorService.getFilterByAge(startAge, endAge).ToArray();

            foreach (var item in result) 
            {
                Console.WriteLine($"{item.Name} - {item.Surname} - {item.Address}");
            }
        }
    }
}
