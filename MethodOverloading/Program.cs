using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var answer1 = Add(2, 2, true);
            Console.WriteLine(answer1); ;
        }
        public static int Add(int x, int y) 
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y) 
        {
            return x + y;
        }
        public static string Add(int x, int y, bool withDollars ) 
        {
            if (withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && (x + y) == 1) 
            {
                return $"{x + y} dollar";
            }
            else 
            {
                return $"{x + y}";
            }
        }
    }
}
