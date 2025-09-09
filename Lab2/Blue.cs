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
            
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / Math.Pow(x, i - 1);
            }

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            double fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                answer += Math.Pow(-1, i) * Math.Pow(5, i) / fact;
            }

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            if (n <= 0)
                return 0;
            
            long a = 0, b = 1;
            
            for (int i = 1; i < n; i++)
            {
                answer += b;
                long temp = a + b;
                a = b;
                b = temp;
            }

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int sum = 0;
            
            while (true)
            {
                int term = a + answer * h;
                if (sum + term > L) break;
                sum += term;
                answer++;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;

            while (true)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
                if (elem <= 0.0001) break;
            }

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            int cells = S;
            
            while (cells < L)
            {
                cells *= 2;
                answer += h;
            }
            

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            double dailyDistance = S;
            double percent = I / 100.0;
            double totalDistance = 0;

            for (int day = 1; day <= 7; day++)
            {
                totalDistance += dailyDistance;
                dailyDistance *= (1 + percent);
            }
            
            a = totalDistance;
            dailyDistance = S;
            totalDistance = 0;
            b = 0;
            
            while (totalDistance < 100)
            {
                b++;
                totalDistance += dailyDistance;
                dailyDistance *= (1 + percent);
            }

            dailyDistance = S;
            c = 0;
            
            while (dailyDistance <= 42)
            {
                c++;
                dailyDistance *= (1 + percent);
            }

            if (S > 42)
                c = 0;
            
            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 0.000001; x += h)
            {
                double localSum = 0;
                double term;
                int i = 0;
        
                do
                {
                    double factorial = 1;
                    for (int j = 1; j <= i; j++)
                        factorial *= j;
                
                    term = (2 * i + 1) * Math.Pow(x, 2 * i) / factorial;
            
                    localSum += term;
                    i++;
                }
                while (Math.Abs(term) >= E);
        
                double yValue = (1 + 2 * x * x) * Math.Exp(x * x);
        
                SS += localSum;
                SY += yValue;
            }

            return (SS, SY);
        }
    }
}