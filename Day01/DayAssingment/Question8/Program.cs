//8) Write a program to find LEAP year by using – 
//a.If – Else and logical operators.
//b. Conditional operator.
//c. Note – A Leap year is divisible by 4 and is not divisible by 100 but it could be divisible by 400.

namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year :- ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 ==0 && year % 400==0)
            {
                Console.WriteLine(year + " is Leap Year!!!! ");
            }
            else
            {
                Console.WriteLine(year + " is Not a Leap Year!!!! ");
            }
        }
    }
}
