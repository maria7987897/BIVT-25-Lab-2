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

	    for (int i = 0; i < n; i++){
	      answer += (p+h*i)*(p+h*i);
	    }

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
	    
	    while (a>=b){
	      quotient++;
	      a-=b;
	    }
	    remainder = a;

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

	    float ch1 = 1;
	    float ch2 = 2;
	    float zn1 = 1;
	    float zn2 = 1;
	    while (Math.Abs(ch2 / zn2 - ch1 / zn1) >= 0.0001){
	      ch2 = ch1+ch2;
	      ch1 = ch2-ch1;
	      zn2 = zn1+zn2;
	      zn1 = zn2-zn1;
	    }
	    answer = ch2 / zn2;


            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
	    int i = 1;
	    for (; Math.Abs(b) > 0.0001; i++){
	      b*=q;
	    }
	    answer = i;

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
	    
	    long number = a;
	    while(b>0){
	      number*=b;
	      b--;
	    }
	    while(number>=10){
	      number/=10;
	      answer++;
	    }

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
	    
	     long sum = 0;
	     ulong n = 1;
	     for (int i = 0; i < 63; i++){
	       n*=2;
	     }
	     answer = (long)((ulong)n/(ulong)15*(ulong)2/(ulong)1000/(ulong)1000);

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
	    long elapsed = 0;
	    d/=100;
	    double S2=S;
	    while(S2<=S+S){
	      if (d*S2+S2>=S+S){
		elapsed += (long)(Math.Ceiling((S+S-S2)/(d*S2/12)));
		break;
	      }
	      else{
		elapsed+=12;
		S2+=S2*d;
	      }
	    }

	    answer = (int)elapsed;

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

	    double cheat;
	    for (double x = a; x <= b; x = Math.Round(x+h, 7)){
	      SY+=Math.Cos(x);
	      double xx = 1;
	      double fac = 1;
	      double last = 1;
	      cheat = 0;
	      int i = 0;
	      while (Math.Abs(last)>=0.0001){
		SS+=last;
		i++;
		fac*=(i*2*(i*2-1));
		xx*=x;
		if (i%2==1){
		  last = xx*xx/fac*(-1);
		}
		else{
		  last = xx*xx/fac;
		}
	      }
	    }

            // end

            return (SS, SY);
        }
    }
}
