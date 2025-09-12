namespace Lab2
{
    public class White
    {
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (3 * i - 1);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (double i = 1; i <= n; i++)
            {
                answer += (1 / i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer += 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long s = a;
            if (b == 0)
            {
                answer = 1;
            }
            else
            {
              for (long i = 1; i < b; i++)
                {
                    s *= a;
                }
            answer = s;  
            }               
            // end
            
            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            int n1 = 0;
            for (int n = 1; p <= L; n += 3)
            {
                p *= n;
                n1 = n;
            }
            answer = n1;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            const double E = 0.0001;

            // code here
            double s = 1;
            while (s >= E)
            {
                answer += s;
                s *= x * x;
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (sum < n) {
                answer++;
                sum += answer;
            }
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double t = ((Math.Sqrt(R*R + L*L)) - R )/ v;
            answer = (int)Math.Ceiling(t);
            // end

            return answer;
        }
    }
}
