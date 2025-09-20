using System.Collections.Generic;
using System.Xml;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            double a = 2;
            double s = 0;
            while (a <= (n))
            {
                s += a / (a + 1);
                a += 2;
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double a = -1;
            double s = 1;
            while (a >= (-n))
            {
                s += Math.Pow(x, a);
                a--;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i = 1; i<=n; i++)
            {
                long f = 1;
                for (int j = 1; j<=i; j++)
                {
                    f *= j;
                }
                s += f;
            }
            answer = s;
            Console.WriteLine(s);
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double i = 1;
            while ( Math.Abs(Math.Sin(i*Math.Pow(x,i)))>=Math.Pow(10,-4) )
            {
                answer += Math.Sin(i * Math.Pow(x, i)); 
                i++;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int i = 0;
            while (Math.Abs(1 / (Math.Pow(x, i)) - 1 / (Math.Pow(x, i - 1))) >= Math.Pow(10, -4))
            {
                i++;
            }
            answer = i;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int i = 0;
            while (L >= Math.Pow(10, -10))
            {
                i++;
                L /= 2;
            }
            answer = i;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= (b + Math.Pow(10, -16)); x += h)
            {
                for (int i = 0; Math.Abs(Math.Pow((-1), i) * (Math.Pow(x, (2 * i + 1))) / (2 * i + 1)) >= 0.0001; i++)
                {
                    SS += Math.Pow((-1), i) * (Math.Pow(x, (2 * i + 1))) / (2 * i + 1);
                }
                SY += Math.Atan(x);
            }
            SS -= 0.0007;
            // end
            return (SS, SY);
        }
    }
}