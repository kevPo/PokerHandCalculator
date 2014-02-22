using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PokerHandCalculator
{
    class PokerHandCalculatorMain
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Error: File path was not successfully received.");
                }
                else if (args.Length > 1)
                {
                    Console.WriteLine("Error: Multiple parameters found, please enter one text file path only.");
                }
                else
                {
                    var filePath = args[0];
                    if (!String.IsNullOrEmpty(filePath))
                    {
                        var contents = File.ReadAllText(@filePath);
                        var pokerTable = new PokerTable(contents);
                        var handScore = pokerTable.CalculateScore();
                        Console.WriteLine(handScore);
                    }
                }
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
