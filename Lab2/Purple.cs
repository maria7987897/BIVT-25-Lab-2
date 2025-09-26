using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            int N = 0;
            while (n != 0)
            {
                answer += (int)Math.Pow(p + N * h, 2);
                N = N + 1;
                n = n - 1;
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                a = a - b;
                quotient += 1;

            }
            if (a < b)
            {
                remainder = a;
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

            var e = 0.0001;
            double ch1 = 1;
            double ch2 = 2;
            double zn1 = 1;
            double zn2 = 1;


           while (Math.Abs(ch2 / zn2 - ch1 / zn1) >= e)
            {
                ch2 = ch2 + ch1;
                ch1 = ch2 - ch1;
                zn2 = zn2 + zn1;
                zn1 = zn2 - zn1;
            }
            answer = ch2 / zn2;



            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            var e = 0.0001;
            double a = b;
            answer = 1;
            while (Math.Abs(a) >= e)
            {
                a = a * q;
                answer += 1;
            }
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            
            long numder = a;
            // code here
            while (b > 0)
            {
                numder *= b;
                b--;
            }
            while (numder >= 10)
            {
                numder /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            int i = 0;
            ulong n = 1;
            ulong totalGrains = 0;
            //code here
            
            totalGrains = ulong.MaxValue; // 2^64 - 1
            ulong grams = totalGrains / 15;     // Перевод в граммы
            ulong tons = grams / 1_000_000;     // Перевод в тонны
            answer = (long)tons;
            //end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            // code here
            if (S <= 0 || d <= 0)
            {
                return 0;
            }
            
                double otnmonth = d / 1200;
                double a = S;
                double absmonth = S * otnmonth;
                while (a < 2 * S)
                {
                    a += absmonth;
                    
                    answer += 1;
                    if (answer % 12 == 0 && answer != 0)
                {
                        absmonth = a * otnmonth;
                        
                        
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

            for (double x = a; x <= b + 0.00001; x += h)
            {
                double sumSeries = 0;
                double term = 1;
                int i = 0;

                while (Math.Abs(term) >= epsilon)
                {
                    sumSeries += term;
                    i++;
                    term = term * (-x * x) / ((2 * i - 1) * (2 * i));
                }

                double y = Math.Cos(x);
                SS += sumSeries;
                SY += y;
            }

            // end

            return (SS, SY);
        }
    }
}