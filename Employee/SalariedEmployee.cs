using System;
namespace Employee
{
    public class SalariedEmployee:Employees //an inherited class
    {
        double weeklyWage; 

        public SalariedEmployee(string NI, string name, string surnameC, double weeklyWage):
        base(NI,name,surnameC)
        {

            this.weeklyWage = weeklyWage;
        }

        public override double calcSalary() //calculating the weekly wage
        {
            double ans = weeklyWage * 4;
            return ans;
        }
    }
}
