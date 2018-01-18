using System;
namespace Employee
{
    public class Employees
    {
        string NI;
        string name;
        string surname;

        public Employees(string NI, string name, string surnameC)
        {
            this.NI = NI;
            this.name = name;
            surname = surnameC;
        }

        public virtual double calcSalary()
        {
            return 0;
        }
    }
}
