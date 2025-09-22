using System.Collections.Generic;

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
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 1;
            double prev = 1.0;
            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (1 / x) * prev;
                prev = (1 / x) * prev;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            long prev = 1;
            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (prev * i);
                prev = prev * i;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double a = 1;
            double newX = 1;
            while (Math.Abs(a) >= E)
            {
                newX = x * newX;
                a = Math.Sin(i * newX);
                answer += a;
                i++;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 2;

            // code here
            double a = 1.0 / x;
            double b = 1.0 / (x * x);
            while (Math.Abs(a - b) >= E)
            {
                a = b;
                b = b / x;
                answer++;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
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
            while (L >  Da)
            {
                L = L / 2;
                answer++;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b+0.0000001; x += h)
            {
                int i = 0;
                int p = -1;
                double num = 1;
                double ActValS = 1;

                while (Math.Abs(ActValS) >= E)
                {
                    ActValS = -p * x * num / (2 * i + 1);
                    SS += ActValS;
                    num = num * x * x;
                    i++;
                    p = -p;
                }

                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}