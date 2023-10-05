using Encap_service_control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encap_service_control.Services
{
    internal class EmployeeService
    {
        public Employee[] GetAllEmployee()
        {
            Employee employee1 = new()
            {
                Name = "Nurlan",
                Surname = "Musayev",
                Age = 21,
                Salary =4500
            };


            Employee employee2 = new()
            {
                Name = "Rufet",
                Surname = "Nesibov",
                Age = 25,
                Salary = 1600
            };

            Employee employee3 = new()
            {
                Name = "Ramin",
                Surname = "Mahmudov",
                Age = 32,
                Salary = 1900
            };

            Employee employee4 = new()
            {
                Name = "Samil",
                Surname = "Ferruxov",
                Age = 29,
                Salary = 4000
            };


            Employee[] employees = {employee1,employee2, employee3, employee4};

            return employees;   
        }


        public Employee[] getFilterBySalary(int start,int end)
        {
            Employee[] employees = GetAllEmployee();

            var result = employees.Where(x => x.Salary > start && x.Salary < end).ToArray();

            return result; 
        }
    }
}
