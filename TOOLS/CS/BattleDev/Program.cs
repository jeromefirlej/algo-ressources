namespace BattleDev
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                Console.WriteLine(Math.Pow(int.Parse(line), 2));
            }
            //résultat
            Console.WriteLine();
        }

        private static int[] GetIntsLine() => Console.ReadLine().Split(" ").Select(v => Int32.Parse(v)).ToArray();
        
        private static int GetIntLine() => Int32.Parse(Console.ReadLine());

        private static bool CollectionEqual<T>(IEnumerable<T> coll1,IEnumerable<T> coll2 ) => Enumerable.SequenceEqual<T>(coll1, coll2);
    }
}
