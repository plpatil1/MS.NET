//11) Write a program to find maximum of 3 numbers using – 
//a.If – else.
//b.Conditional operators.

namespace Question11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            // Using if-else
            //int max;
            //if (num1 > num2)
            //{
            //    max = num1;
            //}
            //else if (num2 > num3)
            //{
            //    max = num2;
            //}
            //else
            //{
            //    max = num3;
            //}
            //Console.WriteLine("Maximum Number is:-  "+max);


            //using Conditional Operator

            int max = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);

            Console.WriteLine("Maximum Number is:-  " + max);
        }
    }
}
