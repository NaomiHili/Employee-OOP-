using System;
namespace Employee
{
    public class CommissionEmployee:Employees
    {
        double TotalSales;
        double CommisionPecentage;

        public CommissionEmployee(string NI, string name, string surnameC,double TotalSales,double CommisionPecentage):
        base(NI, name, surnameC)
        {
            this.TotalSales = TotalSales;
            this.CommisionPecentage = CommisionPecentage;
        }

        public override double calcSalary()
        {
            double ans = TotalSales * (CommisionPecentage / 100);
            return ans;
        }
    }
}
