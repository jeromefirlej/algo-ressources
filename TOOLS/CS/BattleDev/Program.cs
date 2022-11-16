using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BattleDev
{
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

        private static int[] GetIntsLine() {         
            var datasplit = Console.ReadLine().Split(" ");
            int[] b = new int[datasplit.Length];
            int i = 0;
            foreach(string v in datasplit){
                b[i] =  Int32.Parse(v);
                i++;
            }
            return b;
        }
        
        private static int GetIntLine() => Int32.Parse(Console.ReadLine());

        private static bool CollectionEqual<T>(IEnumerable<T> coll1,IEnumerable<T> coll2 ) => Enumerable.SequenceEqual<T>(coll1, coll2);
    }
}
