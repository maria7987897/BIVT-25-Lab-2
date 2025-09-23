using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
            double s = 0.0;
            double del = 1.0;

            for (int m = 1; m <= n; m++)
            {
                s += Math.Sin(m * x) / del;
                del *= x;
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0.0;
            double znam = 5.0;
            double fac = 1.0;
            int znak = -1;

            for (int m = 1; m <= n; m++)
            {
                fac *= m;
                s += znak * (znam / fac);
                znak *= -1;
                znam *= 5;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n > 1)
            {
                int c1 = 0;
                int c2 = 1;
                int s = 1;
                for (int m = 2; m < n; m++)
                {
                    int sled = c1 + c2;
                    s += sled;
                    c1 = c2;
                    c2 = sled;
                }
                answer = s;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            int c = 0;

            for (int n = 1; s <= L; n++)
            {
                if ((s + (a + (n - 1) * h)) > L)
                {
                    break;
                }
                s += (a + (n - 1) * h);
                c++;
            }
            answer = c;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;

            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                elem = ch / zn;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int c = 0;
            while (S < L)
            {
                S *= 2;
                c += h;
            }
            answer = c;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double proz = I / 100.0;
            double sa = S;
            a = sa;
            double kmb = 0;
            double sb = S;
            double sc = S;
            
            for (int i = 2; i <= 7; i++)
            {
                sa = sa + sa * proz;
                a += sa;
            }

            while (kmb < 100)
            {
                kmb += sb;
                sb = sb + sb * proz;
                b += 1;
            }

            while (sc <= 42)
            {
                sc = sc + sc * proz;
                c += 1;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}