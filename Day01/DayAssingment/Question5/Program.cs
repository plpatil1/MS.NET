// 5) Write a program to swap two variables using a third variable by Console Application.
namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers for Swapping ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers before swapping: num1 = " + num1 + ", num2 = " + num2);
            int temp; // Temporary variable for swapping
            temp = num1; // Store num1 in temp
            num1 = num2;
            num2 = temp; // Assign temp to num2
            Console.WriteLine("Numbers after Swapping: num1 = "+ num1 + ", num2 = " + num2);
        }
    }
}
