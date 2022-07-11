using System;

namespace pingpongtable
{
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number to count to: ");
    string stringMaxNumber = Console.ReadLine();
    int maxNumber = int.Parse(stringMaxNumber);

    for (int i=1; i<=maxNumber; i++)
    {
      if (i % 3 == 0 && i % 5 == 0) {
        Console.WriteLine("ping-pong");
      } else if (i % 3 == 0) {
        Console.WriteLine("ping");
      } else if (i % 5 == 0) {
        Console.WriteLine("pong");
      } else {
        Console.WriteLine(i);
      }
    }
  }
}
}