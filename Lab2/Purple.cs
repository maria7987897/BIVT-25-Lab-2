using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += (int)Math.Pow(p + i * h, 2);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                a -= b;
                quotient++;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double epsilon = 0.0001;
            double firstch = 1;
            double firstzn = 1;
            double secondch = 2;
            double secondzn = 1;
            double thirdch = 3;
            double thirdzn = 2;
            while (Math.Abs(thirdch / thirdzn - secondch / secondzn) >= epsilon)
            {
                firstch = secondch;
                firstzn = secondzn;
                secondch = thirdch;
                secondzn = thirdzn;
                thirdch = firstch + secondch;
                thirdzn = firstzn + secondzn;
                answer = thirdch / thirdzn;
            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double epsilon = 0.0001;
            double element = b;
            int n = 1;
            while (Math.Abs(element) >= epsilon)
            {
                element *= q;
                n += 1;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            long a = 1;

            for (int i = 1; i < 63; i++)
            {
                a *= 2;
                answer += a;
            }
            answer /= (15 * 1000 * 500);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double izn = S;
            double Procent = 0;
            int n = 0;
            while (izn > S / 2)
            {
                if (izn > (S + S * d / 100))
                {
                    S += S * d / 100;
                    n += 12;
                }
                else
                {
                    if (n % 12 == 0)
                    {
                        Procent = S * d / 12 / 100;
                    }
                    S += Procent;
                    n += 1;
                }
            }
            answer = n;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double epsilon = 0.0001;
            double s;
            for (double x = a; x <= b + 0.000001; x += h)
            {
                bool IsOPen = true;
                int i = 0;
                s = 1;
                while (IsOPen)
                {
                    if (i == 0)
                    {
                        SS += 1;
                        i += 1;
                    }
                    else
                    {
                        s *= (-1) * x * x / ((2 * i) * (2 * i - 1));
                        SS += s;
                        if (Math.Abs(s) < epsilon)
                        {
                            IsOPen = false;
                        }
                        i += 1;
                    }
                }
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}

