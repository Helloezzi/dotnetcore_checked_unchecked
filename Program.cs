using System;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(int.MaxValue);
                int temp = int.MaxValue;
                //Console.WriteLine(checked(++temp));
                Console.WriteLine(unchecked(++temp));
            }
            catch
            {
                Console.WriteLine("An exception occurred because of an overflow.");
            }
        }
    }
}
