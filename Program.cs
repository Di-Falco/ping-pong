using System;

namespace PingPongTable
{
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number to count to: ");
    string stringMaxNumber = Console.ReadLine();
    int maxNumber = int.Parse(stringMaxNumber);

    PingPongTable.checkNum(maxNumber);
  }
}
}