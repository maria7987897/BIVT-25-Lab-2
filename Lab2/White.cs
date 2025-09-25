namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int s = (3 * n * n + n) / 2;
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            // code here
            for (int x = 1; x <= n; x++)
            {
                answer += (1.0 / x);
            }
                
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int x = 1;x <= n;x++)
            {
                answer *= x;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int x = 1;x <= b;x++)
            {
                answer *= a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;
            int p = 1;
            // code here
            for (int n = 1;p<=L;n += 3)
            {
                p *= n;
                answer = n;
            }
            
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            double s = 0;
            // code here
            for (int n = 0;Math.Pow(x, n)>= Math.Pow(10, -4);n += 2)
            {
                s += Math.Pow(x, n);
                answer = s;

            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            
            for (int sum = 0;sum < n;)
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
            double h = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(L, 2)) - R;
            double time = h / v;
            answer = (int)Math.Ceiling(time);
            // end
            

            return answer;
        }
    }
}
