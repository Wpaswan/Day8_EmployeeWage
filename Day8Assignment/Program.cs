
Console.WriteLine("Welcome To Employee Wage Computation!");

int isPresent = 1;
Random random = new Random();
int randominput = random.Next(0, 2);

if (randominput == isPresent)
{
    Console.WriteLine("Present");
}
else
{
    Console.WriteLine("Absent");
}
Console.ReadLine();