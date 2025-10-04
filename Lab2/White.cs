namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
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
                answer += 1 / i;
            }

            // end

                return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            // end

                return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= b; i++)
            {
                answer *= a;
            
            }
            
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 1;


            // code here
            int p = 1;
            while (answer <= L)
            {
                p += 3;
                answer *= p;
            }
            answer = p;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 1;
             

            // code here
            double pow = x * x;

            while (pow >= E)
            {
                answer += pow;
                pow *= x * x;
                
                
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
            int R = 6371;

            // code here
            double D = 0;
            double h = v;
            while (D <= L)
            {
                D = Math.Sqrt((R + h) * (R + h) - R * R);
                h += v;
                answer++;
            }

            // end

                return answer;
        }
    }
}



