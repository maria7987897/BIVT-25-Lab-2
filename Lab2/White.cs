namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here

            int p = 1;
            int i = 1;
            answer = 1;
            while (p <= L)
            {
                i += 3;
                p *= i;
                answer = i;
            }

            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here

            double eps = 0.0001;
            double pw = 1;
            while (pw >= eps)
            {
                answer += pw;
                pw *= x * x;
            }

            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here

            double indic2 = 0;
            int time = 0;
            double L2 = L * L;
            while (indic2 < L2)
            {
                double h = time * v;
                answer = time;
                indic2 = (R + h) * (R + h) - R * R;
                time++;
            }

            // end

            return answer;
        }
    }
}