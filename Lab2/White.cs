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
            double s = 1;
            double eps = 0.0001;
            while ()
            

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

            // end

            return answer;
        }
    }

}
=
