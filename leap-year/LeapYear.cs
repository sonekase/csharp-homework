using System;

class LeapYear
{
  static void Main()
  {
    Console.WriteLine("What year are you born in?");
    string stringBirthYear = Console.ReadLine();
    int birthYear = int.Parse(stringBirthYear);

    Console.WriteLine("You were alive during these leap years:");
    for (int year = birthYear; year <=2016; year ++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
  }
}
