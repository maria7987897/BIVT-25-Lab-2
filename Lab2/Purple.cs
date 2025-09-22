using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization.Metadata;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = p*p;

            // code here
            double summa = 0;
            for (int i=0; i <= (n-1); i++)
            {
                summa += Math.Pow(p + i * h, 2);
            }
            answer = (int)summa;
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            quotient = a / b;
            remainder = a - quotient * b;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

            double chll = 1, znll = 1, chl = 2, znl = 1;
            while (true)
            {
                double ch = chll + chl;
                double zn = znll + znl;
                double fr_l = chl / znl;
                double fr_new = ch / zn;
                chll = chl;
                znll = znl;
                chl = ch;
                znl = zn;
                if (Math.Abs(fr_new - fr_l) < 0.0001)
                {
                    answer = fr_new; break;
                }
            }

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double num = b;
            while (Math.Abs(num) >= 0.0001)
            {
                num *= q;
                answer++;
            }
            // end

            return answer+1;
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
            BigInteger seeds_add = 2;
            BigInteger seeds = 2;
            BigInteger t = 0;
            for (int i = 0; i < 63; i++)
            {
                seeds += seeds_add;
                seeds_add *= 2;
            }
            t = seeds / 15 / 1000000;
            answer = (long) t;
            // end
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double req = S * 2;
            double curr = S;
            double plus = d / 1200;
            while (curr < req)
            {
                curr += S * plus;
                answer++;
                if (answer % 12 == 0)
                {
                    S = curr;
                }
            }
            // end
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            // code here
            double epsilon = 0.0001;

            for (double x = a; x <= b + 0.0001; x += h)
            {
                double y = Math.Cos(x);
                SY += y;
                double sx = 0;
                for (int i = 0; ; i++)
                {
                    int factorial = 1;
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        factorial *= j;
                    }
                    double s = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / factorial;
                    sx += s;
                    if (Math.Abs(s) < epsilon)
                    {
                        break;
                    }
                }
                SS += sx;

                // end
            }

            return (SS, SY);
        }   
    }
}