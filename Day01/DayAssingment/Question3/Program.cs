// 2) 3) Write a program to accept 5 marks from the user and calculate their sum using Console Application.

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Marks !");

            int mark1 = int.Parse(Console.ReadLine());
            int mark2 = int.Parse(Console.ReadLine());
            int mark3 = int.Parse(Console.ReadLine());
            int mark4 = int.Parse(Console.ReadLine());
            int mark5 = int.Parse(Console.ReadLine());

            int sum = mark1 + mark2 + mark3 + mark4 + mark5;
            

            Console.WriteLine("Sum of 5 Marks is: " + sum);
        }
    }
}
