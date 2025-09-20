using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 0;
            for (int nn = n; nn != 0; nn -= 1)
            {
                s = s + Math.Sin(x * nn) / Math.Pow(x, nn - 1);
            }
            return s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            // code here
            double s = 0;
            double five = 1;
            double factorial = 1;
            int sign = 1;
            for (int i = 1; i <= n; i += 1)
            {
                five *= 5;
                factorial *= i;
                sign *= -1;
                s+=sign*(five/factorial);
            }
            return s;
            // end
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n >= 2)
            {
                List<int> Fibonachi=new List<int>();
                Fibonachi.Add(0);
                Fibonachi.Add(1);
                for (int i = 2; i <= n-1; i++)
                {
                    Fibonachi.Add(Fibonachi[i-2] + Fibonachi[i - 1]);
                }
                return Fibonachi.Sum();
            }
            else
            {
                return 0;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            var s = 0;
            int n = 0;
            while (s <= L)
            {
                s += a + n * h;
                n += 1;
            }
            return n-1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            
            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            ch += i;
            zn *= x;
            answer += elem;
            elem = ch / zn;
            i += 1;
            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i += 1;
            }
            return answer;
            // end
            
            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S <= L)
            {
                S *= 2;
                answer += h;
            }
            return answer;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double TotalPath = 0;
            double InOneDay = S;
            for (int i = 1; i <= 7; i += 1)
            {
                TotalPath += InOneDay;
                InOneDay += (InOneDay / 100)*I;
            }
            a=TotalPath;

            double TotalPath2 = 0;
            double InOneDay2 = S;
            int Days1 = 0;
            while (TotalPath2 <= 100)
            {
                TotalPath2 += InOneDay2;
                InOneDay2 += (InOneDay2 / 100)*I;
                Days1++;
            }

            b = Days1;
            
            double InOneDay3 = S;
            int Days2 = 0;
            while (InOneDay3 <= 42)
            {
                InOneDay3 += (InOneDay3 / 100)*I;
                Days2++;
            }
            c = Days2;
            
            
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            
            double SS = 0;
            double SY = 0;

            // code here

            for (double x = a; x <= b + 1e-10; x += h)
            {
                double s = 0.0;
                double gg = 1.0;
                int i = 0;
                int damn = 0;

                while (true)
                {
                    s += gg;
                    if (Math.Abs(gg) < E || damn++ >= 1_000_000)
                        break;

                    gg = gg * (x * x) * (2.0 * i + 3.0) / ((i + 1.0) * (2.0 * i + 1.0));
                    i++;
                }

                double y = (1.0 + 2.0 * x * x) * Math.Exp(x * x);

                SS += s;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}
