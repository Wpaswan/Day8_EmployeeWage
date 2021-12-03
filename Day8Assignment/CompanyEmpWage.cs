using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHourPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company,int empRatePerHour, int maxHourPerMonth, int totalEmpWage)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxHourPerMonth = maxHourPerMonth;
            this.totalEmpWage = totalEmpWage;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage=totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :"+this.company+" is:"+this.totalEmpWage;
        }
        
    }
}
