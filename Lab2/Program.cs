namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            Blue blue = new Blue();

            Console.WriteLine(blue.Task1(15, -1.42));
            Console.WriteLine(blue.Task2(10));
            Console.WriteLine(blue.Task3(3));
            Console.WriteLine(blue.Task4(0, 1, 10));
            Console.WriteLine(blue.Task5(1.1));
            Console.WriteLine(blue.Task6(1, 1, 100));
            Console.WriteLine(blue.Task7(1, 0.1));
            Console.WriteLine(blue.Task8(0.1, 0.99, 0.01));
        }
    }
}
