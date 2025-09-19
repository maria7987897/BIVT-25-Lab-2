namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            Blue blue = new Blue();

            Console.WriteLine(blue.Task1(15, -1.42));
            Console.WriteLine(blue.Task2(10));
            Console.WriteLine(blue.Task3(11));
            Console.WriteLine(blue.Task4(3, 30, 100));
        }
    }
}
