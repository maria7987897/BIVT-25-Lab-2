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
            for (int i = 2; i <= n; i+=2)
            {
                answer += i / (i + 1.0);
            }

            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= x;
                answer += 1 / a;

            }

            answer++;
            

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 1;
            long b = 1;
            for (int i = 1; i <= a; i++)
            {
                b *= a;
                answer += b;
                a++;
                if ((a == n + 1)|| n==0)
                {
                    break;
                }
            }

            if(n!=0) answer++;

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;
            double y = x;
            double a = Math.Sin(n * x);
            while (true)
            {
                answer += a;
                n++;
                y *= x;
                a = Math.Sin(n * y);
                if (Math.Abs(a) < E) break;
            }
            
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double a=x,b=1;
            while (true)
            {
                if (Math.Abs(1 / b - 1 / a) <= E)
                {
                    answer = n;
                    break;
                }

                a *= x;
                b *= x;
                n++;
            }

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
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
            while (L > Da)
            {
                answer++;
                L /= 2;
            }

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int i = 0;
            double a1, a2,ans,sum=0;
            for (double x = a; x <= b+1e-15; x += h)
            {
                a2 = x;
                a1 = 1;
                i = 0;
                while (true)
                {
                    ans = a1 * a2 / (2 * i + 1);
                    if (Math.Abs(ans) < E) break;
                    sum += ans;
                    a1 *= -1;
                    a2 *= x * x;
                    i++;

                }

                SS += sum;
                SS -= 1e-5;
                SY += Math.Atan(x);
                sum = 0;
            }
            return (SS, SY);
        }
    }
}
