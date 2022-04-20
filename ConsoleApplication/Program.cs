using System;
Console.Write("Please Enter Your First Name > ");
string userName = Console.ReadLine();

Console.Write("Where are you from? > ");
string location = Console.ReadLine();

DateTime today = System.DateTime.Today;
DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);

int daysToChristmas = (christmas - today).Days;

Console.WriteLine($"My name is {userName} ");
Console.WriteLine($"I am from {location}");
Console.WriteLine($"Today is {today.ToShortDateString()}, there are {daysToChristmas} days until Christmas");
Console.ReadKey();