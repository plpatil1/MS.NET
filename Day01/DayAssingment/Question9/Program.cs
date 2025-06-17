//9) Write a program to accept the basic salary and total sales amount from a salesperson and calculate commission according to the sales amount. Display the net salary and commission earned.
//Sales Amount in Rs.      |     Commission(%) on Sales
//5,000 to 7,500           |      3
//7,501 to 10,500          |      8
//10,501 to 15,000         |      11
//15,000 to above          |      15


namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Basic Salary:-  ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Total Sale Amount:-  ");
            int salesAmount = int.Parse(Console.ReadLine());

            if (salesAmount >= 5000 && salesAmount <= 7500)
            {
                double commission = (3 * salesAmount) / 100;
                double netSalary = salary + commission;
                Console.WriteLine("Commission Earned: " + netSalary);
            } else if(salesAmount >= 7501 && salesAmount <= 10500)
            {
                double commission = (8 * salesAmount) / 100;
                double netSalary = salary + commission;
                Console.WriteLine("Commission Earned: " + netSalary);
            } else if(salesAmount >= 10501 && salesAmount <= 15000)
            {
                double commission = (11 * salesAmount) / 100;
                double netSalary = salary + commission;
                Console.WriteLine("Commission Earned: " + netSalary);
            } else if(salesAmount > 15000)
            {
                double commission = (15 * salesAmount) / 100;
                double netSalary = salary + commission;
                Console.WriteLine("Commission Earned: " + netSalary);
            } else
            {
                Console.WriteLine("Sales Amount is below the minimum threshold for commission calculation.");
                Console.WriteLine("No commission earned.");
                Console.WriteLine("Net Salary: " + salary);
            }
        }
    }
}
