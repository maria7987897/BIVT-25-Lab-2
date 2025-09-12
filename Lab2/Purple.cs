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
            for (int i = 0; i < n; i++)
                answer += (p + i * h) * (p + i * h);
            // end

            return answer;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            int FlagForIterationOfDisolve = 0;
            while (a >= b)
            {
                a = a - b;
                FlagForIterationOfDisolve += 1;
            }

            quotient = FlagForIterationOfDisolve;
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double[] numF = { 1.0, 1.0 };
            double[] numS = { 2.0, 1.0 };

            while (Math.Abs((numS[0] / numS[1]) - (numF[0] / numF[1])) > 0.0001)
            {
                double first = numS[0];
                double second = numS[1];

                numS[0] = numS[0] + numF[0];
                numS[1] = numS[1] + numF[1];

                numF[0] = first;
                numF[1] = second;

            }

            answer = numS[0] / numS[1];
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int n = 1;

            while (Math.Abs(b) > 0.0001)
            {
                b *= q;
                n += 1;
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
            const int GrainsInGram = 15;

            long NumOfGrains = 2;
            long SumOfGrains = NumOfGrains;

            for (int i = 1; i < 62; i++)
            {
                NumOfGrains *= 2;
                SumOfGrains += NumOfGrains;
            }

            double tonOfGrainsFirstPart = ((double)(SumOfGrains / GrainsInGram) / 1_000_000);
            double tonOfGrainsSecondPart = ((double)(NumOfGrains / GrainsInGram * 2) / 1_000_000);

            long ResTon = (long)(Math.Floor(tonOfGrainsFirstPart + tonOfGrainsSecondPart));

            answer = ResTon;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double sumRes = S * 2;

            int numOfMonths = 0;

            double curSum = S;

            while (curSum < sumRes)
            {
                double sumOfPercentInMonth = S * d / 100 / 12;
                curSum += sumOfPercentInMonth;
                numOfMonths++;
                if (numOfMonths % 12 == 0)
                {
                    S = curSum;
                }

            }

            answer = numOfMonths;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {

            double SS = 0;
            double SY = 0;

            // code here
            double summaOfRow = 0;
            double summaOfY = 0;

            for (double row = a; row <= b + 0.000001;)
            {
                for (double i = 0; ; i++)
                {
                    double curNum = Math.Pow((-1), i) * ((Math.Pow(row, 2 * i)));
                    //Count Factorial *** 
                    double numForfact = 2 * i;
                    double factOfNum = 1;
                    for (double j = 1; j <= numForfact; j++)
                    {
                        factOfNum *= j;
                    }
                    //Count Factorial *** 
                    curNum /= factOfNum;

                    if (Math.Abs(curNum) < 0.0001)
                        break;

                    summaOfRow += curNum;
                }
                summaOfY += Math.Cos(row);

                row += h;

            }

            SS = summaOfRow;
            SY = summaOfY;
            // end

            return (SS, SY);
        }
    }
}
