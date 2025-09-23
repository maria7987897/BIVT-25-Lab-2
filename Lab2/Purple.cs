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

            for (int i=0; i<n; i++) {
                answer += (p+i*h)*(p+i*h) ;
            }

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            while (a>=b) { 
                quotient++;
                a -= b;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
           

            int x;
            int y;
            int p;
            x = 1;
            y = 2;

            while (true)
            {
                p = y-x;
                if (y*p - x*x >0 && (y*p - x*x)*10000< p*x )
                {
                    break;
                }else if (y*p - x*x < 0 && (x*x - y*p)*10000< p*x )
                {
                    break;
                }

                y = x+y;
                x = y - x;
            }

            answer = (double)y / (double)x; 
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double some = b;
            answer++;
            while (true)
            {
                if (some>0 && some * 10000 < 1) break;
                if (some<0 && some * 10000 > -1) break;
                some *= q;
                answer++;
            }
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
            double grams = 0; 
    double grains = 1;

    for (int i = 1; i <= 64; i++)
    {
        grams += grains / 15.0;
        grains *= 2;
    }

    answer = (long)(grams / 1_000_000.0);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            if (S <= 0 || d <= 0) return 0;

    double current = S;       
    double target = 2 * S;    
    double monthly = 0;       
    int monthsLeft = 0;       

    while (current < target)
    {
        if (monthsLeft == 0)
        {
            double annualIncome = current * d / 100.0;
            monthly = annualIncome / 12.0;
            monthsLeft = 12;
        }

        current += monthly;
        answer++;
        monthsLeft--;
    }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            if (h > 0)
            {
                for (double x = a; x <= b + 1e-12; x += h)
                {
                    double s = 0.0, term = 1.0;
                    for (int i = 0; Math.Abs(term) >= E; i++)
                    {
                        s += term;
                        term *= -x * x / ((2 * i + 1) * (2 * i + 2));
                    }
                    SS += s;
                    SY += Math.Cos(x);
                }
            }
            else if (h < 0)
            {
                for (double x = a; x >= b - 1e-12; x += h)
                {
                    double s = 0.0, term = 1.0;
                    for (int i = 0; Math.Abs(term) >= E; i++)
                    {
                        s += term;
                        term *= -x * x / ((2 * i + 1) * (2 * i + 2));
                    }
                    SS += s;
                    SY += Math.Cos(x);
                }
            }
            // end

            return (SS, SY);
        }
    }
}