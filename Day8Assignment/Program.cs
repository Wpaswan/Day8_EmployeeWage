
Console.WriteLine("Welcome To Employee Wage Computation!");

int isPresent = 1;
int Is_Full_Time = 1;
int emp_hrs = 0;
int empWage=0;
int Emp_Rate_per_Hour = 20;
Random random = new Random();
int randominput = random.Next(0, 2);

if (randominput == isPresent)
{
    emp_hrs=8;
}
else if (randominput == isPresent)
{
    emp_hrs=4;
}
else
{
    emp_hrs = 0;
}
empWage=emp_hrs*Emp_Rate_per_Hour;
Console.WriteLine("Employee Wage:"+empWage);