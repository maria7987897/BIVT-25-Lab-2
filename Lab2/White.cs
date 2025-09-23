using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Security.Cryptography;

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
                answer += 3*i-1;
                
            }
            Console.WriteLine(answer);

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double a = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += a / i;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i <= n; i++) {
                answer *= i;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i<=b ;i++) {
                answer *= a;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int s = 1;
            int s11 = 0;
            for (int i = 1; s <= L ; i+=3)
            {
                s *= i;
                s11 = i;
            }
            answer = s11;
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            answer = 1;
            double x1 = x * x;
            while (x1 >= E) {
                answer += x1;
                x1 *= x * x;
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            for (int sum = 0; sum < n; sum+=answer) {
                answer++;
            }
            return answer;
            Console.WriteLine(answer);

            // end

                return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double h = 0;
            double L1 = 0;

            while (L1 <= L)
            {
                answer++; 
                h = v * answer;  
                L1 = Math.Sqrt((R + h) * (R + h) - R * R);  
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
    }

}
