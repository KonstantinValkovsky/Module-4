namespace Module4._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            double x = 2.3;
            double y = 4.7;
            bool c = (a < b) | (x > y);

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}