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
            double powX = (1/x);
            for (int i = 0; i < n; i++)
            {
                powX *= x;
                answer += ( (Math.Sin((i + 1) * x)) / powX );
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            long f = 1;
            double five = 1;
            for (int i = 1; i <= n; i++)
            {
                five *= 5;
                f *= i;
                if (i % 2 == 0)
                {
                    answer += (five / f);
                }
                else
                {
                    answer -= (five / f);
                }
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0;
            long b = 1;
            for (int i = 0; i < (n-1); i++)
            {
                a += b;
                a = a + b;
                b = a - b;
                a = a - b;
                answer += a;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int i = 0;
            long s = 0;
            while (s <= L)
            {
                s += (a + (i * h));
                answer += 1;
                i++;
            }
            answer -= 1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elen = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elen;
                elen = ch / zn;
                i++;
            }
            while (elen > E);
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
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double aI = 1;
            I = 1 + (I / 100);
            for (int day = 0; day < 7; day++)
            {
                a += (aI * S);
                aI *= I;
            }
            
            aI = 1;
            double bS = 0;
            while (bS < 100)
            {
                bS += (aI * S);
                aI *= I;
                b++;
            }
            
            aI = 1;
            double cS = 0;
            while ((aI * S) <= 42)
            {
                cS += (aI * S);
                aI *= I;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b; x = Math.Round(x + h, 7))
            {
                double Yi = 1;
                double Si = 1;
                int i = 0;
            
                double fx = 1;
             
                float fi = 1;
                while (Math.Abs(Si) >= E)
                {
                    Si = (((2 * i + 1) * (fx * fx)) / (fi));
                    i++;
                    fi *= i;
                    fx *= x;
                    SS += Si;
                
                    Yi = (1 + 2 * x * x) * Math.Pow(Math.E, (x * x));
                }
                SY += Yi;
            }
            // end

            return (SS, SY);
        }
    }

}
