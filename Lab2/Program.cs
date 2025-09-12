using System.Threading.Tasks.Dataflow;

namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            Blue blue = new Blue();
            var input = new double[,] {
                { 0,    0.1,  0.1,  0.01,  0,  0,    0.1,  0.1,  0.1 },
                { 0.1,  0.2,  0.2,  0.1,   1,  0.5,  0.99, 0.5,  0.99 },
                { 0.01, 0.01, 0.02, 0.01, 0.1, 0.05, 0.09, 0.05, 0.01 } };
            for (int i = 0; i < 9; i++)
            {
                double a = input[0, i], b = input[1, i], c = input[2, i];
                for (double x = a; x <= b; x += c)
                {
                    Console.WriteLine(Math.Round(x, 2));
                }
            }
        }
    }
}
