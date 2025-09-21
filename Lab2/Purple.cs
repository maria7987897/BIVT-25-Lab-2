using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total += (p + i * h) * (p + i * h);
            }
            answer = total;
            // end

            return answer;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            // code here
            // b может равняться 0 проверить тесты
            if (b != 0)
            {
                quotient = a / b;
                remainder = a % b;
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double chi_1 = 1;
            double chi_2 = 2;
            double zn_1 = 1;
            double zn_2 = 1;

            while (Math.Abs(chi_1 / zn_1 - chi_2 / zn_2) >= E) {
                double temp = chi_1;
                double tempz = zn_1;

                chi_1 = chi_2;
                chi_2 = temp + chi_2;

                zn_1 = zn_2;
                zn_2 = tempz + zn_2;

            }
            answer = chi_2 / zn_2;

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;

            // code here
            double value = b;
            while (Math.Abs(value) >= E)
            {
                value *= Math.Abs(q);
                answer++;
            }
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
            ulong temp = 1;
            ulong total = temp;

            for (int i = 1; i < 64; i++)
            {
                temp *= 2;
                total += temp;
            }
            answer = (long)(total / 15 / 1000 / 1000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double payment = S * ((double)d / 1200);
            double total = S;
            while (total < 2 * S)
            {
                total += payment;
                answer++;
                if (answer % 12 == 0)
                {
                    payment = total * ((double)d / 1200);
                }
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (decimal x = (decimal) a; x <= (decimal) b; x += (decimal) h)
            {
                decimal v = 1;
                int i = 1;
                int power = 1;
                while ((double)Math.Abs(v) >= E)
                {
                    i = -i;
                    decimal chi = 1;
                    decimal znam = 1;
                    SS += (double)v;
                    for (int j = 1; j <= 2 * power; j++)
                    {
                        chi *= x;
                    }

                    for (int j = 0; j < 2 * power; j++)
                    {
                        znam *= (2 * power - j);
                    }
                    v = i * (decimal)chi / znam;
                    power += 1;
                }
                SY += Math.Cos((double)x);
            }
        return (SS, SY);
        }
    }
}