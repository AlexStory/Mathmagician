using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("I am the Mathgician");
      Console.WriteLine("What Shall I Math?");
      Console.WriteLine("Fibonacci, Primes, or Integers?");
      string desiredMaths = Console.ReadLine();
      Console.WriteLine("Ok, I'm gonna do some " + desiredMaths);

      if (desiredMaths == "Integers") {
        PrintIntegers();
      } if (desiredMaths == "Fibonacci") {
        int prev = 0;
        int current = 1;
        while (true) {
          Console.WriteLine(current);
          int newNum = prev + current;
          prev = current;
          current = newNum;
          System.Threading.Thread.Sleep(100);
        }
      } if (desiredMaths == "Prime") {
        int start = 2;
        while (true) {
          bool prime = true;
          for (int i = start - 1; i > 1; i--) {
            if (start % i == 0) {
              prime = false;
            }
          }
          if (prime == true) {
            Console.WriteLine(start);
          }
          start += 1;
          System.Threading.Thread.Sleep(100);
        }
      }

      Console.WriteLine("Press any ey to exit...");
      Console.ReadKey();
    }

    private static void PrintIntegers() {
      int nextInteger = 0;
      while (true) {
        nextInteger++;
        Console.WriteLine(nextInteger);
      }
    }
  }
}
