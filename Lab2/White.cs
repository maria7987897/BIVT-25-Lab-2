using System.ComponentModel.Design;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            
            int s = 0;
            for (int i = 1; i <=n; i++)
            {
                s += 3 * i - 1;
                
            }
            answer = s;
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            
            double s = 0.0;
            for (int i = 1; i <= n; i++)
            {
                s += 1.0 / i;

            }
            answer = s;


            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            answer = s;

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;
            long s = 1;
            for (int i = 1; i <= b; i++)
            {

                s *=a;
            }
            answer = s;

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;
            int b = 1;
            int p = 1;
            while (p <= L)
            {
                b += 3;
                p = p * b;
            }
            answer = b;

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            double eps = 1e-4;
            double sum = 0;
            double term = 1;

            while (Math.Abs(term) >= eps)
            {
                sum += term;
                term *= x * x;
            }
            answer = sum;

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;
            int sum = 0;
            while (sum < n)
            {
                if (sum < n)
                {
                    answer++;
                    sum += answer;
                }
                
            }

            return answer;    
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0;
            for(int t = 0; t < 1000; t++)
            {
                double h = v * t;
                double kat1 = R + h;
                
                double l = kat1*kat1 - R*R;
                if (Math.Sqrt(l) > L)
                {
                    answer = t; break;
                }
            }

            

            return answer;
        }
    }

}
