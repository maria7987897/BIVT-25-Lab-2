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
            for (double i = 2; i <= n; i += 2) answer += i / (i + 1);
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i++) answer += Math.Pow(x, -i);
                // end

                return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            answer = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                answer += f;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            for (int i = 1; Math.Abs(Math.Sin(i * Math.Pow(x, i))) >= 0.0001; i++) answer += Math.Sin(i * Math.Pow(x, i));
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            while (Math.Abs(1 / Math.Pow(x, answer) - (1 / Math.Pow(x, answer - 1))) >= 0.0001) answer++;
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
            while (L > 0.0000000001)
            {
                L /= 2;
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
            for (double x = a; x <= b; x = Math.Round(x + h, 4))
            {
                double s = 0;
                double k = x;
                double c = 1;
                for (int i = 0; Math.Abs(c * k / (2 * i + 1)) >= 0.00001 ; i++)
                {
                    s += c * k / (2 * i + 1);
                    c *= -1;
                    k *= x * x;
                }
                SS += s;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}