// 6) Accept a character from a user and print its ASCII value using Console Application.
namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Single Character and Get Their ASCI Value:-  ");
            char ch = Console.ReadKey().KeyChar; 
Console.WriteLine("You Entered Character is :- "+ch);
            int asciiValue = (int)ch; // Convert character to ASCII value
            Console.WriteLine("ASCII Value of " + ch + " is: " + asciiValue); // Print ASCII value
            Console.ReadLine(); // Wait for user input before closing the console
        }
    }
}
