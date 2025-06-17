//12) Write a program to accept an Employee no. And department no. As numeric data and designation code as
//character data. Display the entered data with proper messages as below and refer the below table for
//entered data – 



//Department no.    |   Department Name    |     Designation Code      |    Designation
//10                    Purchase                    ‘M’                     Manager
//20                    Sales                       ‘S’                     Supervisor
//30                    Production                  ‘A’                     Analyst
//40                    Marketing                   ‘s’                     Sales Person
//50                    Accounts                    ‘a’                     Accountant

namespace Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department no.");
            int departmentNo = int.Parse(Console.ReadLine());

        }
    }
}
