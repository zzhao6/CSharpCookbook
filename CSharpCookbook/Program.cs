using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSort();
        }

        public static void TestSort()
        {
            List<Square> listOfSquares = new List<Square>()
            {
                new Square(1, 3),
                new Square(4, 3),
                new Square(2, 1),
                new Square(6, 1)
            };
            // Test a list<string>
            Console.WriteLine("List<String>");
            Console.WriteLine("Original list");
            foreach (var square in listOfSquares)
            {
                Console.WriteLine(square.ToString());
            }

            Console.WriteLine();
            IComparer<Square> heightCompare = new CompareHeight();
            listOfSquares.Sort(heightCompare);
            Console.WriteLine("Sorted list using IComparer<Square>=heightCompare");
            foreach (var sq in listOfSquares)
            {
                Console.WriteLine(sq.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Sorted list using IComparable<Square>");
            listOfSquares.Sort();
            foreach (var sq in listOfSquares)
            {
                Console.WriteLine(sq.ToString());
            }


            // Test a sortedlist
            var sortedListOfSquares = new SortedList<int, Square>()
            {
                {0, new Square(1, 3)},
                {1, new Square(4, 3)},
                {2, new Square(2, 1)},
                {3, new Square(6, 1)}
            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SortedList<Square>");
            foreach (KeyValuePair<int, Square> kvp in sortedListOfSquares)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}
