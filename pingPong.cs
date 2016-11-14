using System;

public class PinPong
{
  public static void Main()
  {
    Console.WriteLine("Please enter a number for me to count to: ");
    string userInput = Console.ReadLine();
    int userNumber = int.Parse(userInput);

    for (int i = 0; i <= userNumber; i++)
    {
      if(i % 15 == 0)
      {
        Console.WriteLine("Ping-Pong");
      } else if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }else if(i % 5 == 0)
      {
        Console.WriteLine("Pong");
      } else
        Console.WriteLine(i);
    }
  }
}
