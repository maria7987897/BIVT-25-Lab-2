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

                Console.WriteLine(blue.Task8(input[0, i], input[1, i], input[2, i]));
            }
        }
    }
}
