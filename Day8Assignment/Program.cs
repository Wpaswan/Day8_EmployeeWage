
namespace Day8Assignment
{
    internal class ComputeEmployeeWage
    {
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public ComputeEmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public static void Compute_wage()
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
        public string toString()
        {
            return "Total Emp Wage for company:"+this.company+" is:"+this.totalEmpWage;
        }
        public static void Main(String[] args)
        {
            ComputeEmployeeWage dMart = new ComputeEmployeeWage("Dmart", 20, 2, 10);
            ComputeEmployeeWage reliance = new ComputeEmployeeWage("Reliance", 10, 4, 20);


        }
        
    }
   
}
