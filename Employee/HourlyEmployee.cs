using System;
namespace Employee
{
    public class HourlyEmployee:Employees    //here we are using  the enheritance from the employees class
    {
        double HourlyRate;
        double HoursWorked;

        public HourlyEmployee(string NI, string name, string surnameC, double HourlyRate, double HoursWorked):
        base(NI, name, surnameC)
        {
            this.HourlyRate = HourlyRate;
            this.HoursWorked = HoursWorked;
        }

        public override double calcSalary()
        {
            double ans = HourlyRate * HoursWorked;
            return ans;
        }
    }
}
