using System;
namespace Employee
{
    public class BaseCommEmployee:CommissionEmployee
    {
        double WeeklyWage;

        public BaseCommEmployee(string NI, string name, string surnameC, double TotalSales, double CommisionPecentage, double WeeklyWage):
        base( NI,  name,  surnameC,  TotalSales,  CommisionPecentage)
        {
            this.WeeklyWage = WeeklyWage;
        }

        public override double calcSalary()
        {
            double ans = base.calcSalary() + (WeeklyWage * 4);
            return ans;
        }

    }
}
