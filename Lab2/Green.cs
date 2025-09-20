using System.Collections.Generic;

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
            for (double i = 2; i <= n; i+=2)
                answer += i / (i + 1);
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double zn = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += 1 / zn;
                zn *= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long fac = 1;
            // code here
            for (int i=0; i<=n; i++)
            {
                if (i>0)
                {
                    fac *= i;
                }
                answer += fac;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            for (int n=1; Math.Abs(Math.Sin(n*Math.Pow(x,n)))>=E;n++)
            {
                answer += Math.Sin(n * Math.Pow(x, n));
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double ch = 1 / x;
            for (answer=2; Math.Abs(ch/x - ch)>=E;answer++)
            {
                ch /= x;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem<limit)
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
            while (L>Da)
            {
                L /= 2;
                answer++;
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
                int znak = -1;
                double ch = 1;
                double res = 1;

                for (int i=0; Math.Abs(res)>=E; i++)
                {
                    res = -znak * x * ch / (2 * i + 1);
                    SS += res;
                    ch = ch * x * x;
                    znak = -znak;
                }
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}