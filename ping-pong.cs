using System;

namespace PingPongTable
{
  public class PingPongTable {
    public static void checkNum(int maxNumber)
    {
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