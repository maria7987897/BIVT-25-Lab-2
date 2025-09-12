using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;

        public double Task1(int n)
        {
            double answer = 0;

            if (n > 0)
            {
                for (int i = 2; i <= n; i = i + 2)
                {
                    answer += (double)i / (i + 1);
                }

            }

            return answer;
        }

        public double Task2(int n, double x)
        {
            double answer = 1;

            for (int i = 1; i <= n; i++)
            {
                answer += 1 / (Math.Pow((double)x, i));
            }

            return answer;
        }

        public long Task3(int n)
        {
            if (n < 0) return 0;

            long answer = 1;
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                answer += factorial;
            }

            return answer;
        }

        public double Task4(double x)
        {
            double answer = 0;
            double temp;

            for (int i = 1; i < 10000; i++)
            {
                temp = Math.Sin(i * Math.Pow(x, i));
                answer += temp;
                if (Math.Abs(temp) < E) break;
            }

            return answer;
        }

        public int Task5(double x)
        {
            int answer = 0;
            double temp;
            double temp1;

            for (int i = 0; i < 10000; i++)
            {
                temp = 1 / (Math.Pow(x, i));
                temp1 = 1 / (Math.Pow(x, i - 1));

                if (Math.Abs(temp - temp1) < E)
                {
                    answer = i;
                    break;
                }
            }

            return answer;
        }

        public int Task6(int limit)
        {
            int answer = 0;
            int elen = 1;


            while (elen < limit)
            {
                elen *= 2;
                answer += elen;
            }

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            int c = 0;
            double temp = L;

            while (temp > Da)
            {
                c++;
                temp /= 2;
            }

            answer += c;

            return answer;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            
            for (double x = a; x <= b + 1e-12; x += h)
                //1e-12 нужно для минимальной погрешности
            //то есть комп о,1 хранит как 0,10001 и тогда будет ошибка потому что результат не точный
            {
                int i = 0;
                double temp;
                double sum = 0;
                do
                {
                    temp = Math.Pow(-1, i) * (Math.Pow(x, 2 * i + 1) / (2 * i + 1));
                    sum += temp;
                    i++;
                } while (Math.Abs(temp) > E);

                SS += sum;
                SY += Math.Atan(x);
            }

            return (SS, SY);
                
        }
    }
}
