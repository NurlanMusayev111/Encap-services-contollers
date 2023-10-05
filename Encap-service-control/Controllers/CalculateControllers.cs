using Encap_service_control.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encap_service_control.Controllers
{
    internal class CalculateControllers
    {
        public void Calculation()
        {
            CalculateService calc = new CalculateService();

            double num1 = 5;
            double num2 = 10;

            calc.Calculation(num1, num2);
            
        }

        
    }
}