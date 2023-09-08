using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Abstraction
{
    public class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double netSalary;

        public Employee(int Eid, string Ename, double EgrossPay)
        {
            EmpId = Eid;
            EmpName = Ename;
            GrossPay = EgrossPay;
        }


        private void CalculateSalary()
        {
            if (GrossPay >= 45000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your salary is :{0}", netSalary);

            }
            else
            {
                Console.WriteLine("Your salary is {0}", GrossPay);
            }
        }

        public void ShowEmployeeDetails()
        {
            CalculateSalary();
        }
    }

}
