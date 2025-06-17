//13) Enter date in dd/mm/yy format. Write a program to print total no. Of days in a month and month
//    as character month.


namespace Question13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date in dd/mm/yy format :- ");
            String dateInput = Console.ReadLine();
            try
            {
                DateTime date = DateTime.ParseExact(dateInput, "dd/MM/yy", null);
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                string monthName = date.ToString("MMMM");
                Console.WriteLine($"Total number of days in {monthName} is: {daysInMonth}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please enter the date in dd/mm/yy format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
