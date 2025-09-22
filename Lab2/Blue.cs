using System.Collections.Generic;
using System.ComponentModel;
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
            for (int i = 1; i <= n; i++)
            {
                answer += double.Sin(i*x)/double.Pow(x, i-1);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            long factorial(int a) 
            {  
                if (a == 0) return 1;  
                return a * factorial(a - 1);  
            }  

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    answer += Math.Pow(5, i)/factorial(i);
                }
                else
                {
                    answer -= Math.Pow(5, i)/factorial(i);
                }
                
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fibonacci(int num)
            {
                if (num <= 0)
                {
                    return 0;
                }

                var nums = new List<long>() { 0 };
                if (num > 1)
                {
                    nums.Add(1);
                }

                for (int i = 2; i < num; i++)
                {
                    nums.Add(nums[i - 1] + nums[i - 2]);
                }

                return nums.Sum();
            }

            answer = fibonacci(n);
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s=0;
            while (s <= L)
            {
                answer++;
                s += (a + (answer - 1) * h);
                
            }

            answer--;
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
            while (S < L)
            {
                S *= 2;
                answer += h;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double rust(int n)
            {
                double sum = 0;
                double s1=S;
                for (int i = 1; i <= n; i++)
                {
                    sum += s1;
                    s1 += s1 * (I / 100);
                }
                return sum;    
            }

            a = rust(7);
            while (rust(b) < 100)
            {
                b++;
            }

            int c1 = 1;
            while (rust(c1) - rust(c) <= 42)
            {
                c1++;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double eps = 0.0001;
            for (double x = a; x <= b + 1e-12; x += h)
            {
                double sum = 0; 
                int i = 0;  
                double n; 
                double factorial = 1;
                double x_pow = 1;
                double x_sq = x * x;
                do
                {
                    if (i > 0)
                    {
                        factorial *= i;  
                        x_pow *= x_sq;
                    }
                    n = (2 * i + 1) * x_pow / factorial;
                    sum += n;
                    i += 1;
                }
                while (n >= eps);

                
                double y = (1 + 2 * x * x) * Math.Exp(x * x); 
                SS += sum;
                SY += y;

            }
            // end

            return (SS, SY);
        }
    }

}
