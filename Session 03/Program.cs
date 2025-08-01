using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace Session_03
{
    internal class Program
    {

        public static bool IsValidDate(int day, int month, int year)
        {
            if (year < 1900 || year > DateTime.Now.Year)
                return false;

            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsDuplicate(int id, Employee[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != null && arr[j].Id == id)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Q1-Q2-Q3
            //Employee[] Emp = new Employee[3];

            //for (int i = 0; i < Emp.Length; i++)
            //{
            //    Console.WriteLine($"Enter data for Employee #{i + 1}");

            //    int id;
            //    bool IsParseId;
            //    do
            //    {
            //        Console.Write("Enter Employee Id: ");
            //        IsParseId = int.TryParse(Console.ReadLine(), out id);
            //        if (!IsParseId || id <= 0 )
            //        {
            //            Console.WriteLine("Invalid ID");

            //        }
            //        if (IsParseId && IsDuplicate(id, Emp))
            //        {
            //            Console.WriteLine("ID already exists");
            //            IsParseId = false;
            //        }

            //    } while (!IsParseId || id <= 0 );

            //    Console.Write("Enter Name: ");
            //    string name = Console.ReadLine();

            //    decimal salary;
            //    bool IsParseSalary;
            //    do {                     
            //        Console.Write("Enter Salary: ");
            //        IsParseSalary = decimal.TryParse(Console.ReadLine(), out salary);
            //        if (!IsParseSalary || salary < 0)
            //        {
            //            Console.WriteLine("Invalid Salary. Please enter a non-negative number.");
            //        }
            //    } while (!IsParseSalary || salary < 0);

            //    Gender gender;
            //    bool isParse;
            //    do
            //    {
            //        Console.Write("Enter Gender : ");
            //        isParse = Enum.TryParse(Console.ReadLine(), true, out gender);
            //    } while (!isParse);

            //    SecurityPrivileges security;
            //    bool isParseSecurity;

            //    do
            //    {
            //        Console.Write("Enter Security Level: \n(Guest, Developer, Secretary, DBA, SecurityOfficer): ");
            //        isParseSecurity = Enum.TryParse(Console.ReadLine(), true, out security);
            //        if (!isParseSecurity)
            //            Console.WriteLine("Invalid Security Level. Try again.");
            //    } while (!isParseSecurity);

            //    int day, month, year;
            //    bool IsValidDay;
            //    bool IsValidMonth;
            //    bool IsValidYear;
            //    do
            //    {
            //        Console.Write("Enter Hire Day: ");
            //        IsValidDay= int.TryParse(Console.ReadLine(), out day);
            //        Console.Write("Enter Hire Month: ");
            //        IsValidMonth= int.TryParse(Console.ReadLine(), out month);
            //        Console.Write("Enter Hire Year: ");
            //        IsValidYear= int.TryParse(Console.ReadLine(), out year);
            //        if (!IsValidDay || !IsValidMonth || !IsValidYear || !IsValidDate(day, month, year))
            //        {
            //            Console.WriteLine("Invalid date, please try again.");
            //            IsValidDay = false;
            //            IsValidMonth = false;
            //            IsValidYear = false;
            //        }
            //    } while (!IsValidDay&&!IsValidMonth&&!IsValidYear);
            //    HiringDate hireDate = new HiringDate(day, month, year);

            //    Emp[i] = new Employee(id, name, security, salary, hireDate, gender);
            //    Console.WriteLine("\n");
            //}
            //Console.Clear();
            //Console.WriteLine("Employees List:");
            //foreach (var employee in Emp)
            //{
            //    if (employee != null)
            //    {
            //        Console.WriteLine(employee);
            //    }
            //}
            #endregion

            #region Q4
            //for (int i = 0; i < Emp.Length - 1; i++)
            //{
            //    for (int j = 0; j < Emp.Length - i - 1; j++)
            //    {
            //        DateTime d1 = new DateTime(Emp[j].HireDate.Year, Emp[j].HireDate.Month, Emp[j].HireDate.Day);
            //        DateTime d2 = new DateTime(Emp[j + 1].HireDate.Year, Emp[j + 1].HireDate.Month, Emp[j + 1].HireDate.Day);

            //        if (d1 > d2)
            //        {
            //            Employee temp = Emp[j];
            //            Emp[j] = Emp[j + 1];
            //            Emp[j + 1] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("\nEmployees after sorting by hire date:");
            //foreach (var emp in Emp)
            //{
            //    Console.WriteLine(emp);
            //}

            // There is no boxing or unboxing in the above code
            // Because we are not converting any value type to object 


            #endregion



        }
    }
}
