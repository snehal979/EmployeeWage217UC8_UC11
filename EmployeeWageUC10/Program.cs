namespace EmployeeWageUC10
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeTotalWageArray employeeTotalWageArray = new EmployeeTotalWageArray();   
            employeeTotalWageArray.addCompanyEmpWage("DMart", 20, 2, 10);
            employeeTotalWageArray.addCompanyEmpWage("Reilance", 10, 4, 20);

            employeeTotalWageArray.DataOfEmployee();

            // for interface get method call and its return type

            Console.WriteLine( "total wage of company is" +employeeTotalWageArray.getTotalEmpWage(1));



        }
    }
}