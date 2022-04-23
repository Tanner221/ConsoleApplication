using System;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2
            Console.Write("Please Enter Your First Name > ");
            string userName = Console.ReadLine();

            Console.Write("Where are you from? > ");
            string location = Console.ReadLine();

            DateTime today = System.DateTime.Today;
            DateTime christmas = new DateTime(today.Year, 12, 25);

            int daysToChristmas = (christmas - today).Days;

            //if days to christmas is positive, check christmas this year, else check next year (after christmas)
            daysToChristmas = daysToChristmas >= 0 ? daysToChristmas : (christmas.AddYears(1) - today).Days;

            Console.WriteLine($"My name is {userName} ");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine($"Today is {today.ToShortDateString()}, there are {daysToChristmas} days until Christmas");
            

            //2.1 example
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Enter Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Enter Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            //End Program
            Console.WriteLine("Press Any Key to End");
            Console.ReadKey();
        }
       
    }
}