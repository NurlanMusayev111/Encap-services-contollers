using Encap_service_control.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encap_service_control.Controllers
{
    internal class EmployeeControllers
    {
        public void GetFilterBySalary()
        {
            int start = 3500;
            int end = 5000;

            EmployeeService employees = new EmployeeService();

            var result = employees.getFilterBySalary(start, end);

            foreach(var employee in result)
            {
                Console.WriteLine($"{employee.Name} - {employee.Surname} - {employee.Age}");
            }

        }
    }
}
