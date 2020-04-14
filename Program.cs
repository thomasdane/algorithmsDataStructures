using System;
using System.Collections.Generic;

namespace algorithmsDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Stringsplosion.Run("Code"));
            Console.WriteLine(Stringsplosion.Run("x"));
            Console.WriteLine(Stringsplosion.Run("ab"));
            Console.WriteLine(Stringsplosion.Run("Bad"));

            Console.WriteLine(MaxSpan.Run(new List<int> { 1, 4, 2, 1, 4, 4, 4 }));
            Console.WriteLine(MaxSpan.Run(new List<int> { 1, 4, 2, 1, 4, 1, 4 }));
            Console.WriteLine(MaxSpan.Run(new List<int> { 3, 3, 3 }));
            Console.WriteLine(MaxSpan.Run(new List<int> { 3, 9, 3 }));
            Console.WriteLine(MaxSpan.Run(new List<int> { 3, 9, 9 }));
            Console.WriteLine(MaxSpan.Run(new List<int> { 3, 9 }));
            Console.WriteLine(MaxSpan.Run(new List<int> { 3, 3 }));
            Console.WriteLine(MaxSpan.Run(new List<int> ()));
            Console.WriteLine(MaxSpan.Run(new List<int> { 3 }));
        }
    }
}
