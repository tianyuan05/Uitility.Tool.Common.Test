using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            long rs = dt.ToInt64();

         
            Console.WriteLine(value: $"{dt.ToString("yyyy-MM-dd HH:mm:ss")}--{rs}");

            Console.WriteLine(value: $"{rs}--{rs.ToDateTime()}");

            Console.ReadKey();
        }
    }
}
