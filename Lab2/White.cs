namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 2; i <= 3 * n - 1; i = i + 3)
            {
                answer = answer + i;
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
                answer = answer + 1/i;
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
                answer *= i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i <= b; i++)
            {
                answer *= a ;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            int n = 1;
            while (p <= L)
            {
                n = n + 3;
                p = p * n;
            }
            answer = n;
            
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            answer = 1;
            int n = 1;
            while (Math.Pow(x, 2*n) >= E)
            {
                answer += Math.Pow(x, 2*n);
                n += 1;
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
            int hours = 0; // переменная для подсчета часов
            double height = 0; // высота
            double distance = 0; // расстояние
            // code here
            while (distance <= L)
            {
                hours++;
                height = hours * v;
                distance = Math.Sqrt(2 * R * height + Math.Pow(height, 2));
            }

            answer = hours;
            // end

            return answer;
        }
    }
}
