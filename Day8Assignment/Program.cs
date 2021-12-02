
namespace Day8Assignment
{
    //Uc8 Use for multiple companies
    internal class ComputeEmployeeWage
    {
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;
        public const int RatePerHrs = 20;
        public const int Max_Working_Days = 20;
        public const int Max_Working_Hrs = 100;
        public static void Compute_wage(string company, int empRatePerHour, int numOfWorkingDay, int MaxHoursPerMonth)
        {

            int empWage = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpWage = 0;
           
            while(totalEmpHrs <=MaxHoursPerMonth && totalWorkingDays<numOfWorkingDay)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case is_Part_Time:
                        empHrs=4;
                        break;
                        case is_Full_Time:
                        empHrs = 8;
                        break;
                        default: empHrs = 0;
                        break;
                }
                totalEmpHrs+=empHrs;
                Console.WriteLine("Days:"+totalWorkingDays+" Emp Hrs:"+empHrs);
            }
             totalEmpWage = totalEmpHrs+empRatePerHour;
            Console.WriteLine("Total Emp Wage for company:"+company+" is:"+totalEmpWage);
            
        }
        public static void Main(String[] args)
        {
            ComputeEmployeeWage.Compute_wage("Dmart",20,2,10);
            ComputeEmployeeWage.Compute_wage("Reliance", 10, 4, 20);
        }
        
    }
   
}
