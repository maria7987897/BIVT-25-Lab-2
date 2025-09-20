using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
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
            double pow = 1;
            answer = Math.Sin(x);
            for (int i = 2; i < n + 1; i++)
            {
                pow *= x;
                answer += (Math.Sin(x * i) / pow);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double pow1 = 1;
            double pow5 = 1;
            double fractN = 1;
            for (int i = 1; i < n + 1; i++)
            {
                pow1 *= -1;
                pow5 *= 5;
                fractN *= i;           
                answer += pow1 * (pow5 / fractN);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long now = 1;
            long pred = 0;
            long temp;
            for (int i = 0; n - 1 > i; i++)
            {
                answer += now;
                temp = now;
                now += pred;
                pred = temp;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            while (s <= L)
            {
                answer++;
                s += (a + ((answer - 1) * h));
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
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            do
            {
                S *= 2;
                answer += h;
            } while (S < L);
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double aS = S;
            for (int i = 0; i < 7; i++)
            {
                aS+=aS * I * Math.Sign(i) * 0.01;
                a+=aS;
            }
            double bS = S;
            double bKm = 0;
            do
            {
                bS+=bS * I * Math.Sign(b) * 0.01;
                bKm+=bS;
                b++;
            } while (bKm < 100);
            double cS = S;
            while (cS <= 42)
            {
                c++;
                cS += cS * I * Math.Sign(c) * 0.01;
            } 
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double el = 0;
            while (el > E)
            {
                break;
                //cock
            }
            // end

            return (SS, SY);
        }
    }
}
