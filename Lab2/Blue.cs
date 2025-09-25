using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 0;
            int i = 0;
            while (i<=n)
            {
                s = s + Math.Sin(i * x) / Math.Pow(x, i - 1);
                i += 1;

            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            int i = 1;
            long f = 1;
            
            
            while (i<=n)
            {
                f = f * i;
                s = s + (Math.Pow(-1, i) * (Math.Pow(5, i) / f));
                i += 1;
                
               
                

            }
            answer = s;

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n==0)
            {
                return 0;
            }
            if (n==1)
            {
                return 0;
            }
            long f1 = 0;
            long f2 = 1;
            long s = f1;
            for (int i = 2; i<=n; i++)
            {
                s += f2;
                long next = f1 + f2;
                f1 = f2;
                f2 = next;
                
            }
            answer = s;
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = a;
            int n = 1;
            int m = a;
            while (s <= L)
            {
                n++;
                m = m + h;
                s += m;
                

            }
            answer = n-1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int n = 0;
            long i = S;
            while (i<=L)
            {
                n = n + h;
                i = i*2;
            }
            answer = n;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double pa = S;
            int na = 1;
            double totala = 0;
            while( na<=7)
            {
                totala += pa;
                na +=1;
                pa = pa + (I / 100.0) * pa;
                
                

            }
            a = totala;

            double pb = S;
            int nb = 0;
            double totalb = 0;
            while (totalb <=100)
            {
                totalb += pb;
                nb += 1;
                pb = pb + (I / 100.0) * pb;
            }
            b = nb;


            double pc = S;
            int nc = 0;
            double totalc = 0;
            while (pc<42)
            {
                totalc += pc;
                nc += 1;
                pc = pc + (I / 100.0) * pc;
                
            }
            c = nc;


            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double ep = 0.0001;
            for (double x = a; x<=b+0.00001; x+=h)
            {
                int i = 0;
                double f = 1;
                double t = 0;
                double sc = 0;
                do
                {
                    t = (2 * i + 1) * (Math.Pow(x, 2 * i)) / f;
                    sc += t;
                    i++;
                    f = f * i;
                } while (Math.Abs(t) >= ep );
                SS += sc;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            
            }
            // end

            return (SS, SY);
        }
    }
}