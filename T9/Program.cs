using System;
using T9Api;

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var t9 = new T9InputSequenceProcessor();

                ConsoleKey? currentKey = null;

                while (true)
                {
                    var key = Console.ReadKey();
                    Console.Write("\b \b");

                    if (key.Key == ConsoleKey.Enter)
                        break;

                    var ch = t9.GetNextLetter(key.KeyChar);

                    if (currentKey == key.Key)
                    {
                        Console.Write("\b");
                        Console.Write(ch);
                    }
                    else
                    {
                        Console.Write(ch);
                        currentKey = key.Key;
                    }
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine();
                Console.WriteLine("Error: only digits allowed");
            }
        }
    }
}
