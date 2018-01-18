using System;
namespace Employee
{
    public class Company
    {
        string name;
        Employees[] employees;

        public Company()
        {
            name = string.Empty;
            employees = new Employees[5];
        }

        public Company(string pName, Employees[] pEmployees)
        {
            name = pName;
            employees = pEmployees;
        }

        public void AddEmployee(Employees emp)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] == emp;
                    break;
                }
            }
        }
    }
}
