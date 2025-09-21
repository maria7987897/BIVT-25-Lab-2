using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 0; n > 0; i++)
            {
                answer += (p + i * h) * (p + i * h);
                n--;
            }

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            while (a >= b)
            {
                quotient++;
                a -= b;
            }
            remainder = a;
            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            int aChisl = 1, aZnam = 1, bChisl = 2, bZnam = 1;
            int cChisl = aChisl + bChisl, cZnam = aZnam + bZnam;
            while (Math.Abs((decimal)bChisl / bZnam - (decimal)cChisl / cZnam) >= ((decimal)1 / 10000))
            {
                cChisl += bChisl;
                cZnam += bZnam;
                bChisl = cChisl - bChisl;
                bZnam = cZnam - bZnam; 
            }
            answer = (double)cChisl / cZnam;
            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;
            b = Math.Abs(b);
            while (b >= E)
            {
                answer++;
                b *= Math.Abs(q);
            }

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

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

            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            int kletki = 64;
            ulong zerno = 1;
            ulong vsegoZerna = zerno;
            while (kletki > 1)
            {
                zerno *= 2;
                vsegoZerna += zerno;
                kletki--;
            }
            answer = (long)(vsegoZerna / 15 / 1000000);
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double s1 = S;
            double x = (S * (d / 100)) / 12;
            while (S < s1 * 2)
            {
                if (answer % 12 == 0)
                {
                    x = (S * (d / 100)) / 12;
                }
                S += x;
                answer++;


            }
            


            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
             for (decimal x = (decimal) a; x <= (decimal) b; x += (decimal) h)
            {
                decimal v = 1;
                int znak = 1, stepen = 1;
                while ((double)Math.Abs(v) >= E)
                {
                    SS += (double)v;
                    znak = -znak;
                    decimal ch = 1, zn = 1;

                    for (int k = 0; k < 2 * stepen; k++)
                    {
                        zn *= 2 * stepen - k;
                    }

                     for (int k = 1; k <= 2 * stepen; k++)
                    {
                        ch *= x;
                    }

                    v = znak * ch / zn;
                    stepen += 1;
                }
                SY += Math.Cos((double)x);
            }

            return (SS, SY);
        }
    }
}