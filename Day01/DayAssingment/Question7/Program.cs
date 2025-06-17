// 7) Write a program to calculate Net Salary of an employee using Basic Salary based on following parameters – 
// using System.Text.RegularExpressions;

//a.HRA is 20 % of basic salary.
//b.DA is 40 % of basic salary.
//c.PF is 10 % of Gross salary.
//d.Gross Salary is Basic Salary + HRA + DA.
//e. Net salary is Gross Salary – PF.

namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary :-  ");
            int salary = int.Parse(Console.ReadLine());
            int HRA = (20 * salary) / 100; // Calculate HRA as 20% of basic salary
            int DA = (40 * salary) / 100; // Calculate DA as 40% of basic salary    
            int pf = (10 * (salary + HRA + DA)) / 100; // Calculate PF as 10% of Gross Salary
            int grossSalary = salary + HRA + DA; // Calculate Gross Salary
            int netSalary = grossSalary - pf; // Calculate Net Salary
            Console.WriteLine("Basic Salary: " + salary);               
            Console.WriteLine("HRA (20% of Basic Salary): " + HRA); 
            Console.WriteLine("DA (40% of Basic Salary): " + DA);
            Console.WriteLine("Gross Salary (Basic + HRA + DA): " + grossSalary);
            Console.WriteLine("PF (10% of Gross Salary): " + pf);
            Console.WriteLine("Net Salary (Gross Salary - PF): " + netSalary); // Print Net Salary

        }
    }
}
