//10) Using a switch case write a menu driven program to perform basic calculations of two user entered numbers.
namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int choice;
            do
            {
                Console.WriteLine("Select an operation: ");
               
                Console.WriteLine("2. Subtraction");
                
                Console.WriteLine("3. Multiplication");
                
                Console.WriteLine("4. Division");
                
                Console.WriteLine("5. Modulus");
               
                Console.WriteLine("0. Exit");
                choice = int.Parse(Console.ReadLine());


                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Addition: " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication: " + (num1 * num2));
                        break;
                    case 4:
                        if (num2 != 0)
                            Console.WriteLine("Division: " + ((double)num1 / num2));
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                    case 5:
                        Console.WriteLine("Modulus: " + (num1 % num2));
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
            while (choice != 0);
        }
    }
}
