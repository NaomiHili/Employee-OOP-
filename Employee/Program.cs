using System;

namespace Employee
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employees[] employees = new Employees[4];


            Menu();



            Console.WriteLine("What kind of employee are you: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1.Salaried Employee");
            Console.WriteLine("2.Hourly Employee");
            Console.WriteLine("3.Commissioin Employee");
            Console.WriteLine("4.Base Commision Employee");
            int subMenu = Convert.ToInt32(Console.ReadLine());

       
            switch (subMenu)
            {
                case 1:
                    SalariedEmployee();
                    Menu();
                    break;
                case 2:
                    HourlyEmployee();
                    Menu();
                    break;
                case 3:
                    CommissioinEmployee();
                    Menu();
                    break;
                case 4:
                    BaseCommisionEmployee();
                    Menu();
                    break;
                default:
                    Console.WriteLine("Your choice was invalid");
                    Environment.Exit(0);
                    break;
            }

        }

        static void SalariedEmployee()
        {
            Console.Write("Enter your NI number: ");
            int NI = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your weekly wage: ");
            double weeklyWage = Convert.ToDouble(Console.ReadLine());

        }

        static void HourlyEmployee()
        {
            Console.Write("Enter your NI number: ");
            int NI = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your hour rate: ");
            double HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of hours worked: ");
            double HoursWorked = Convert.ToDouble(Console.ReadLine());
        }

        static void CommissioinEmployee()
        {
            Console.Write("Enter your NI number: ");
            int NI = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Emter your total number of sales: ");
            double TotalSales = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your commission percentage: ");
            double CommisionPecentage = Convert.ToDouble(Console.ReadLine());
        }

        static void BaseCommisionEmployee()
        {
            Console.Write("Enter your NI number: ");
            int NI = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your weekly wage: ");
            double weeklyWage = Convert.ToDouble(Console.ReadLine());
        }

        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1.Add Employee");
            Console.WriteLine("2.Calc Payroll");
            Console.WriteLine("3.Exit");
            int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your choice was invalid try again");
                        Environment.Exit(0);
                        break;
                }  

        }

    }
}
