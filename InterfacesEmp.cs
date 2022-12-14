using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageUC10
{
    internal class InterfacesEmp
    {
        // interface = comapering the three  method 

        public interface IDataemployeeWage
        {
            public void addCompanyEmpWage(string Name, int PerHour, int WorkingDays, int hour);
            public void DataOfEmployee();
            public int getTotalEmpWage(int value);

        }
        public class DataOfEmployee
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;

            public DataOfEmployee(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }

            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }

            public string toString()
            {
                return "Total Emp Wage for company: " + this.company + " is : " + this.totalEmpWage;
            }
        }

    }
}
