using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityPrivileges SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        #endregion

        #region Constructors
        public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, HiringDate hire, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hire;
            Gender = gender;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Security: {SecurityLevel}, Salary: { DisplaySalary() }, Hire Date: {HireDate}, Gender: {Gender}";
        }
        public string DisplaySalary()
        {
           var culture = new System.Globalization.CultureInfo("ar-EG");
           return String.Format(culture, "{0:c}", Salary);
        }
        #endregion

    }
}