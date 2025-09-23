using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;


namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += ((p + i * h) * (p + i * h));
            }
            // code here

            // end

            return s;
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

            int ch1 = 1;
            int zn1 = 1;
            int ch2 = 2;
            int zn2 = 1;
            int ch3 = ch1 + ch2;
            int zn3 = zn2 + zn2;
            while (Math.Abs((decimal)ch2 / zn2 - (decimal)ch3 / zn3) >= ((decimal)0.0001))
            {
                ch3 += ch2;
                zn3 += zn2;
                ch2 = ch3 - ch2;
                zn2 = zn3 - zn2;
            }
            answer = (double) ch3 / zn3;


                // code here

                // end

                return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            double e = 0.0001;
            answer = 1;
            double s = b;
            while (Math.Abs(s) > e)
            {
                answer ++;
                s = b * Math.Pow(q, answer-1);
            }
            // code here

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;

            while (b > 0){
                number *= b;
                b--;
            }
            while (number >= 10) { 
            
                number /= 10;
                answer++;
             
            }
            return answer;
        }
        public long Task6()
        {
            double answer = 0;          
            double c1 = 1;

            for (int i = 0; i < 64; i++)
            {
                answer += c1;
                //c1 /= 15;
                c1 *= 2;
            }
            
            
            return (long)(answer/(1_000_000 * 15));
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double x1 = S;
            double x2 = S;

            double p = d / 12 / 100;

            while (x1 < S * 2)
            {
                x1 += x2 * p;
                answer ++;
                if (answer % 12 == 0)
                {
                    x2 = x1;
                }
            }

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            

            for (double x = a; x - b <= 0.0001; x += h)
            {
                double y = Math.Cos(x);
                SY += y;
                               
                double sx = 1; 
                double t = 1;
                int i = 1;
                double x2 = x * x;

                while (Math.Abs(t) >= 0.0001)
                {
                    
                    t = -t * x2 / ((2 * i - 1) * (2 * i));
                    sx += t;
                    i ++;
                }

                SS += sx;
            }

            return (SS, SY);
        }


    }
}