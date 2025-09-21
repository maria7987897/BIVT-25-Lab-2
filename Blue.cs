using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO.IsolatedStorage;
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
            double m = 1;
            for (int i = 0; i < n; i++, m=m*x)
            {
                answer += Math.Sin((i+1) * x) / (m);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double five = 5;
            double factor = 1;


            for (int i = 1; i <= n; i++)
            {
                five = -five;
                factor = factor * i;
                answer += five / factor;
                five = five * 5;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int num_1 = 0, num_2 = 1, sum;
            for (int i = 1; i < n; i++)
            {
                sum = num_1 + num_2;
                num_2 = num_1;
                num_1 = sum;
                answer += sum;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0, k = 0;

            for (answer = 0; s <= L; answer++)
            {
                s += a + h * k;
                k++;
            }
            if (s == L)
            {
                answer = answer;
            }
            else
            {
                answer = answer - 1; 
            }
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
            int CletokSeichas = S, time = 0;

            while (CletokSeichas < L)
            {
                CletokSeichas *= 2;
                time += h;
            }
            answer = time;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            //code here
            double probejalzaden = S;
            double save = 0;
            double save1 = 0;
            double save2 = 0;
            double probejalzaden2 = S;
            double probejalzaden3 = S;
            for (int i = 1; i <= 6; i++)
            {
                probejalzaden = probejalzaden + (probejalzaden * (I / 100));
                save += probejalzaden;
            }
            a = S + save;
            Console.WriteLine(a);

            int k;
            for (k = 1; save1 + S < 100; k++)
            {
                probejalzaden2 = probejalzaden2 + (probejalzaden2 * (I / 100));
                save1 += probejalzaden2;
            }
            b = k;

            int d = 0;
            //for (d = 1; save2 + S < 42; d++)
            while (probejalzaden3 <= 42)
            {
                probejalzaden3 = probejalzaden3 + probejalzaden3 * (I / 100);
                save2 = probejalzaden3;
                d++;
            }
            c = d;

            //end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double e = 0.0001;
            for (double x = a; x <= b; x = x + h) //а - начало дипазона, b- конец диапазона,h-шаг, начинающий действие с начала диапазона до конца (a to b)
            {
                x = Math.Round(x, 4); //оруг x до 4 знаков после ,
                int i = 1, n = 1; 
                double S = 0;
                double chlenr9da = 1; //текущий член ряда
                while (Math.Abs(chlenr9da) >= e)
                {

                    S = S + chlenr9da;
                    chlenr9da = (2*i + 1) * Math.Pow(x, 2*i) / n;
                    i++; //факториал
                    n = n * i; //факториал
                }
                SS += S + chlenr9da; //сумма ряда дипазона x
            }

            for (double x = a; x <= b; x += h)
            {
                x = Math.Round(x, 4);
                SY += (1 + 2 * x*x) * Math.Pow(Math.E, x*x);// сумма ряда дипазона y
            }
            // end

            return (SS, SY); 
        }
    }
}