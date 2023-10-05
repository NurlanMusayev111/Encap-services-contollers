using Encap_service_control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Encap_service_control.Services
{
    internal class DoctorService
    {
        public Doctor[] GetAllDoctors()
        {
            Doctor doctor1 = new()
            {
                Name = "Mezahir",
                Surname = "Quliyev",
                Address = "Yasamal",
                Birthday = new(1980, 01, 01)
            };

            Doctor doctor2 = new()
            {
                Name = "Firuze",
                Surname = "Eliyeva",
                Address = "Nerimanov",
                Birthday = new(1996, 04, 07)
            };

            Doctor doctor3 = new()
            {
                Name = "Selmi",
                Surname = "Ceferova",
                Address = "Sahil",
                Birthday = new(1999, 07, 03)
            };

            Doctor doctor4 = new()
            {
                Name = "Sebine",
                Surname = "Ismayilova",
                Address = "Iceriseher",
                Birthday = new(1991, 06, 06)
            };

            Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4 };

            return doctors;
        }

        public Doctor[] getFilterByAge(DateTime startAge,DateTime endAge)
        {

            
            Doctor[] doctor = GetAllDoctors();

            var result = doctor.Where(x => x.Birthday > startAge && x.Birthday < endAge).ToArray();

            return result;
        }
    }
}
