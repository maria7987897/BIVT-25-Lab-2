using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (int) Math.Pow(p + (i - 1) * h, 2);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            remainder = a;
            while (remainder >= b)
            {
                remainder -= b;
                quotient++;
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            
            // code here
            double currentNumenator = 2;
            double previousNumenator = 1;
            double currentDenominator = 1;
            double previousDenominator = 1;
            
            double currentItem = currentNumenator / currentDenominator;
            double previousItem = previousNumenator / previousDenominator;
            double difference = Math.Abs(currentItem - previousItem);
            
            while (difference >= E)
            {
                double nextNumenator = currentNumenator + previousNumenator;
                double nextDenominator =  currentDenominator + previousDenominator;
                
                previousNumenator = currentNumenator;
                previousDenominator = currentDenominator;
                
                currentNumenator = nextNumenator;
                currentDenominator = nextDenominator;

                previousItem = currentItem;
                currentItem = nextNumenator / nextDenominator;
                
                difference = Math.Abs(currentItem - previousItem);
            }

            answer = currentItem;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int n = 0;
            while (Math.Abs(b * Math.Pow(q, n - 1)) >= E)
            {
                n++; 
            }
            answer = n;
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }

            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            ulong grains = 1;
            ulong totalGrains = 0;
            for (int i = 1; i <= 64; i++)
            {
                totalGrains += grains;
                grains *= 2;
            }
            answer = (long) (totalGrains/15.0)/1000000;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            if (S <= 0 || d <= 0) return 0;
            int month = 0; // количество месяцев
            double currentAmount = S; // начальная сумма
            double targetAmount = S * 2; // конечная сумма
            double yearIncome = currentAmount / 100.0 * d; // сколько прибавится к сумме за год
            while (currentAmount < targetAmount)
            {
                currentAmount += yearIncome / 12; //нахожу сумму, которая прибавляется в месяц
                month++;
                if (month % 12 == 0)
                {
                    yearIncome = currentAmount / 100.0 * d; // новая сумма, которая прибавится за год
                }
            }
            answer = month;
            // end

            return answer;
        }

        private long Factorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            // code here
            for (double x = a; x <= b; x += h)
            {
                SY += Math.Cos(x); //нашли функцию У
                
                double factorial = 1;
                
                double item = 1;
                int i = 0;
                
                while (Math.Abs(item) >= E)
                {
                    item = Math.Pow(-1, i) * Math.Pow(x, 2*i) / Factorial(2*i);
                    i++;
                    SS += item;
                }
            }
            // end

            return (SS, SY);
        }
    }
}