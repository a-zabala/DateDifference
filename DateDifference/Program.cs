using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date: XX/XX/XXXX");
            //Takes input as a string
            string inputDate1 = Console.ReadLine();
            Console.WriteLine("Please enter a second date: ");
            //Second input as a string 
            string inputDate2 = Console.ReadLine();
            //Turns the string into DateTime
            DateTime date1 = DateTime.Parse(inputDate1);
            DateTime date2 = DateTime.Parse(inputDate2);
            
            //Finds the number of days between dates
            TimeSpan dateDifference = date2.Subtract(date1);
            //Outputs the difference and also finds the absolute value to keep from getting negative
            Console.WriteLine($"The difference between your dates is {Math.Abs(dateDifference.Days)}  days");
            Console.ReadLine();
        }
    }
}
