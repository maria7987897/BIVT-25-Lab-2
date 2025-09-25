namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int b = 2 + 3 * n - 1;
            answer = b * n / 2;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int k = 0;
            while (k < n)
            {
                k += 1;
                answer += 1.0 / k;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= n; i++) answer = answer * i;
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int i = 0; i < b; i++) answer *= a;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int x = 1;
            for (int i = 1; i <= L; x += 3)
            {
                i = x * i;
                answer = x;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double w = 1;
            while (w >= E)
            {
                answer += w;
                w *= x * x;
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;
            int sum = 0;
            // code here
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
            double t = ((Math.Sqrt(R * R + L * L)) - R) / v;
            answer = (int)Math.Ceiling(t);
            // end

            return answer;
        }
    }

}
