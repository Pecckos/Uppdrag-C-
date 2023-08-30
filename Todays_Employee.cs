using System;

namespace Todays_Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            new_person Person = new new_person("Jessica", 28, "Female");
            Person.Run();
            Console.Write("Please press one key to continue...");
            Console.ReadKey(true);


        }
    }


    class new_person
    {
        private string Name;
        private int Age;
        private string Gender;
        private employee[] employees;
        private int counter = 0;


        public new_person(string _name, int _age, string _gender)
        {
            Name = _name;
            Age = _age;
            Gender = _gender;
            employees = new employee[15];
        }

        class employee
        {
            public string Name;
            public int Age;
            public string Gender;

            public employee(string _name, int _age, string _gender)
            {
                Name = _name;
                if (_age < 1)
                    Age = 1;
                else
                    Age = _age;
                Gender = _gender;
            }

        }
        public void Add_employees()
        {
            if (counter > 15) return;

            Console.WriteLine("Write your Name, Age, and if you are a Male or Female");
            Console.WriteLine("Namn:");
            var namn = Console.ReadLine();
            Console.WriteLine("Age:");
            var age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Write if you are a Male or Female:");
            var sex = Console.ReadLine();
            employees[counter] = new employee(namn, age, sex);
            counter++;


        }

        public void Show_employees()
        {
            foreach (var emp in employees)
            {
                if (emp != null)
                {
                    Console.WriteLine("The persons name is {0} and is {1} years old. The gender is {2} ", emp.Name, emp.Age, emp.Gender);
                }
            }

        }

        public void Get_todays_employee()
        {
            Random Slump = new Random();
            int index = Slump.Next(counter);
            Console.WriteLine("Randomly selected employee is " + employees[index].Name);
        }

        public void Statistics_Gender()
        {
            int Female = 0;
            int Male = 0;

            foreach (var employee in employees)
            {
                if (employee != null)
                {
                    if (employee.Gender == "Female")
                    {
                        Female++;
                    }
                    if (employee.Gender == "Male")
                    {
                        Male++;
                    }
                }
            }
            Console.WriteLine("This is how many Females it is " +  Female + "This is how many Males it is " + Male);
        }

        public void Get_Average_Age()
        {
            int TotalAge = 0;
            int EmployeeCount = 0;

            foreach (var employee in employees)
            {
                if (employee != null)
                {
                    TotalAge = TotalAge + employee.Age;
                    EmployeeCount++;
                }

            }
            int medel = TotalAge / EmployeeCount;
            Console.WriteLine(" Here is average " + medel);
        }

        public void Run()
        {
            int temp = 0;

            do
            {
                Console.WriteLine("-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)");
                Console.WriteLine("Welcome! Please choose an option");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Show employees");
                Console.WriteLine("3. Generate todays employee");
                Console.WriteLine("4. Show statistics on how mamy female vs male there are.");
                Console.WriteLine("5. Calculate the average age on the employees");
                Console.WriteLine("0. Exit the program");
                Console.WriteLine("-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)-)");
                temp = int.Parse(Console.ReadLine());

                switch (temp)
                {
                    case 1:
                        Add_employees();
                        break;

                    case 2:
                        Show_employees();
                        break;

                    case 3:
                        Get_todays_employee();
                        break;

                    case 4:
                        Statistics_Gender();
                        break;

                    case 5:
                        Get_Average_Age();
                        break;

                    case 0:
                        Console.ReadKey();
                        break;

                }
            } while (temp != 0);
        }
    }
}