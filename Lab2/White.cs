namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;
            answer = n * (3 * n + 1) / 2;
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            for(int i=1; i<=n; i++)
            {
                answer += 1.0/i;
            }
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            for(int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;
            long t = 0;
            while(t < Math.Abs(b))
            {
                answer *= a;
                t++;
            }
            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;
            int mn1=1, p = 1;
            for (int i = 1; i <= mn1;  i+=3)
            {
                p *= i;
                if(p > L)
                {
                    answer = mn1;
                    break;
                }
                mn1+=3;
            }
                return answer;
        }
        public double Task6(double x)
        {
            double n = 1, j = 1, s = 1;
            for(int i = 1; i <= 2*n && j >= 0.0001; i++)
            {
                j *= (x*x);
                s += j;
                n++;
            }
            return s;
        }

        public int Task7(int n)
        {
            int answer = 0;
            int sum = 0;
            while(sum < n)
            {
                answer++;
                sum += answer;
            }
            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0;
            int t = 0;
            double h = 0, d = 0;
            while(d <= L)
            {
                t++;
                h = t * v;
                d = Math.Sqrt(2 * R * h + h * h);
            }
            answer = t;
            return answer;
        }
    }
}
