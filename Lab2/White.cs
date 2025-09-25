namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            answer = (2 + 3 * n - 1) * n / 2;
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
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer = answer * i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1;i <= b;i++)
            {
                answer = answer * a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int k = 1;
            for (int i = 1; i <= L; k += 3)
            {
                i = k * i;
                answer = k;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            answer = 0;
            for (int i = 0; Math.Pow(x, i) >= Math.Pow(10, -4); i += 2)
            {
                answer += Math.Pow(x, i);
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
            double H = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(L, 2)) - R;
            double t = H / v;
            answer = (int)t + 1;
            // end

            return answer;
        }
    }

}
