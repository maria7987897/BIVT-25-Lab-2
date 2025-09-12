namespace Lab2
{
    public class White
    {
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            if (n == 0) answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            if (n == 0) answer = 0;
            for (double i = 1; i <= n; i++)
            {
                answer += 1 / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer += 1;
            if (n == 0 || n == 1) answer = 1;
            for (long i = 2; i <= n; i++)
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
            answer += 1;
            if (a == 0) answer = 0;
            if (b == 0) answer = 1;
            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            answer += 1;
            int p = 1;
            if (L < 1) answer = 1;
            while (p <= L)
            {
                answer += 3;
                p *= answer;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            const double E = 0.0001;

            // code here
            if (Math.Abs(x) > 1) answer = 1;
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
            while (sum < n)
            {
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
            double h = (Math.Sqrt(R * R + L * L) - R);
            answer = (int)Math.Ceiling(h / v);
            // end

            return answer;
        }
    }
}
