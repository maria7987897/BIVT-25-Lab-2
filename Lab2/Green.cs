using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (double i = 2; i <= n && n>2; i+=2)
            {
                
                answer += i / (i + 1);
            }
            if( n <= 2)
            {
                answer = (double)2 / (double)3;
            }
            if (n == 0)
            {
                answer = 0;
            }

            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double a = 1;
            for(int i = 0; i <= n; i++)
            {
                answer += a ;
                a = a / x;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 1;
            int b = 0;
            long s = 0;
            int i = 0;
            while (i <= n)
            {
                if (i == 0)
                {
                    s += 1;

                }
                else
                {
                    s =s* a;
                    a++;


                }
                i++;
                answer += s;
            }


            
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 100000;
            int a = 1;
            int i = 1;
            double k = x;
            while (i <= n)
            {
                answer += Math.Sin(a * k);
                double r =Math.Abs( Math.Sin(a * k));
                a++;
                k = k * x;
                if (r < 0.0001)
                {
                    break;
                }
                i++;

            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 100000;
            int i = 1;
            double k = x;
            double nowx = 0;
            double lastx = 11111;
            while (i <= n)
            {
                nowx = 1 / k;
                k = k * x;
                if (Math.Abs(nowx - lastx) < 0.0001)
                {
                    answer = i;
                    break;
                }
                lastx = nowx;
                i++;


            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int i = 0;
            int elem = 1;
            while (elem < limit) 
            {
                elem *= 2;
                answer += elem;
                i++;
                
            }

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int i = 1;
            int n = 10000000;
            while (i != n)
            {
                L = L / 2;
                answer++;
                if (L == 0)
                {
                    answer = 0;
                    break;
                }
                if (L <= Da)
                {
                    break;
                }
                i++;
            }

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;


            // code here
            for (double x = a; x <= b + E; x += h)
            {
                SY += Math.Atan(x);
                int sign = -1;
                double mn = 1;
                for (int i = 0; ; i++)
                {
                    double s = -1 * sign * x * mn / (2 * i + 1);
                    SS += s;
                    sign *= -1;
                    mn *= x * x;
                    if (Math.Abs(s) < E)
                    {
                        break;
                    }
                }
            }

            // end

            return (SS, SY);
        }
    }
}
