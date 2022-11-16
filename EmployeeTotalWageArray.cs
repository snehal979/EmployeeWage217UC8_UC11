using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeWageUC10.InterfacesEmp;

namespace EmployeeWageUC10
{
    public class EmployeeTotalWageArray: IDataemployeeWage
    {
        
        
           public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private int numOfCompany = 0;
            private DataOfEmployee[] DataOfEmployeeArray;

            public EmployeeTotalWageArray()
            {
                this.DataOfEmployeeArray = new DataOfEmployee[5];
            }

            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                DataOfEmployeeArray[this.numOfCompany] = new DataOfEmployee(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                numOfCompany++;
            }
            
            // to display   method
            public void DataOfEmployee()
            {
                for (int i = 0; i<numOfCompany; i++)
                {
                    int val = this.EmpWage(this.DataOfEmployeeArray[i]);
                    DataOfEmployeeArray[i].setTotalEmpWage(val);
                    Console.WriteLine(this.DataOfEmployeeArray[i].toString());
                }
            }

            private int EmpWage(DataOfEmployee DataEmpWage)
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                while (totalEmpHrs <= DataEmpWage.maxHoursPerMonth && totalWorkingDays < DataEmpWage.numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day# :" + totalWorkingDays + " Emp Hrs: " + empHrs);
                }
                return totalEmpHrs * DataEmpWage.empRatePerHour;
            }

        // interface due to creat get method
        public int getTotalEmpWage(int value)
        {
            return this.DataOfEmployeeArray[value].totalEmpWage;
        }

    }

}

