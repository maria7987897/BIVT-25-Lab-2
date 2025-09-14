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
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i++)
            {
                answer += Math.Pow(x, -i);
            }
            // end

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                answer += factorial;
            }

            answer += 1;
            // end

            return answer;
        }

        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 0;
            double number = 1;
            double epsilon = 0.0001;
            while (Math.Abs(number) >= epsilon)
            {
                i++;
                number = Math.Sin(i * (Math.Pow(x, i)));
                answer += number;
            }
            // end

            return answer;
        }

        public int Task5(double x)
        {
            // code here
            int answer = 0;
            double epsilon = 0.0001;
            int n = 0;
            while (true)
            {
                double left = (double)1 / Math.Pow(x, n);
                double right = (double)1 / Math.Pow(x, n - 1);
                if (Math.Abs((left) - (right)) < epsilon)
                {
                    break;
                }

                n++;
            }

            answer = n;
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
            while (L > Da)
            {
                L /= 2;
                answer += 1;
            }
            // end

            return answer;
        }
    

    public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b; x += h)
            {
                SY += Math.Atan(x);
                double item = 0;
                int i = 0;
                do
                {
                    item = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
                    i++;
                    SS += item;
                } while (Math.Abs(item)>=E);
            }
            
            // end

            return (SS, SY);
        }
    }
}