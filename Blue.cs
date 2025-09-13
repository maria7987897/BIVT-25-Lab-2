using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double denominator = 1.0;
            for (int i = 0; i < n; i++) {
                answer += Math.Sin((i + 1) * x) / denominator;
                denominator *= x;

            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double numerator = -5;
            double denominator = 1.0;
           
            
            for (int i = 0; i < n; i++)
            {
                denominator *= (i + 1);
                answer += numerator / denominator;               
                numerator *= -5;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long number1 = 0;
            long number2 = 1;
            if (n < 2)
            {
                answer = 0;
            }
            else answer = 1;
            for (int i = 2; i < n; i++)
            {
                {
                        long number3 = number1 + number2;
                        answer += number3;
                        number1 = number2;
                        number2 = number3;
                    }
                }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int cnt = 0;
            int s = 0;
            int commonDifference = 0;
            while (s <= L) {
                cnt += 1;
                s += a + commonDifference;
                commonDifference += h;                               
            }
            answer = cnt - 1;//вычитаем 1 тк при последнем вхождении в цикл добавляется (n+1)-ый член прогрессии 
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1.0;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int amountOfDivisions = 0;
            int amountOfCells = S;
            while (amountOfCells < L)
            {
                amountOfCells *= 2;
                amountOfDivisions += 1;
            }
            answer = amountOfDivisions * h;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            int daysA = 0;
            double dailyDistA = S;
            while (daysA < 7)
            {
                a += dailyDistA;
                dailyDistA += I * dailyDistA / 100;
                daysA += 1;
            }
            double dailyDistB = S;
            double sumDist = 0;
            while (sumDist < 100)
            {
                sumDist += dailyDistB;
                b += 1;
                dailyDistB += I * dailyDistB / 100;
            }
            double dailyDistC = S;
            while (dailyDistC < 42)
            {
                c += 1;
                dailyDistC += I * dailyDistC / 100;
            }
           
             

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double epsilon = 0.0001;
            for (double x = a; x <= b + 1e-11; x += h) //без 1e-11 вместо 11.793435 получалось 10.8...
            {
                double sum = 0;
                int i = 0;
                double s; //для вычисления i-го члена S ряда
                double denominator = 1; //знаменатель минимально равен 1 тк факториал i=0 равен 0!=1
                do
                {
                    if (i != 0)
                    {
                        denominator *= i;
                    }
                    s = (2 * i + 1) * Math.Pow(x, 2 * i) / denominator;
                    sum += s;
                    i++;                       
                }
                while (s >= epsilon);
                    
                SS += sum;
                SY += (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
            }
            // end

            return (SS, SY);
        }
    }
}