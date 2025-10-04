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
                answer+= 3*i - 1;
            }
            // end

            return answer;
        }




        
        public double Task2(int n)
        {
            double answer = 0;
            // code here
            for (int i = 1; i <= n; i++);
            {
                answer+= 1.0 / i;
            }
            // end

            return answer;
        }






        
        public long Task3(int n)
        {
            long answer = 1;
            // code here
            if (n>=0)
            {
                for (int i = 1; i <= n; i++)
                {
                    answer*=i;
                }
            }
            //end
            return answer;
        }





        
        public long Task4(int a, int b)
        {
            long answer = 1.0;
            // code here
            if (b == 0)
            {
                return 1.0;
            }
            bool otric = false;
            if (b < 0)
            {    
                otric = true;
                b = Math.abs(b);
            }
            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }

            if (otric) 
            {
                answer = 1.0 / answer;
            }
      
            // end
            return answer;
        }






        
        public int Task5(int L)
        {
            int answer = 1; // n
            // code here
            int p = 1;
            while ( p <= L)
            {
                p*=(3*answer-2);
                answer+=1;
            }
            
            // end
            return answer - 1;
        }







        
        public double Task6(double x)
        {
            double answer = 1.0; // s
            // code here
            double epsilon = Math.Pow(10, -4);
            doube term = 1.0; //очередной член ряда
            int n = 0; // степень двойки
            do
            {
                n++;
                term*= x*x;
                answer+=term;
            }
            
            while (term >= epsilon)
                return answer;
            // end
            //return answer;
        }

        





        

        public int Task7(int n)
        {
            int answer = 0;
            // code here
            int sum = 0;
            if (sum < n)
            {
                for(int n = 0; sum < n; n++)
                {
                    answer++;
                    sum+=answer;
                }
                
            if (sum >= 0)
            {
                return answer;
            }
            // end
        }








        
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км
            double h = Math.Sqrt(R * R + L * L) - R; // расчёт высоты, на которую нужно подняться
            double t = h / v;                        // время подъёма
            int answer = (int)Math.Round(t);          // округляем время до ближайшего целого
            return answer;
            // end
            //return answer;
        }
    }
    
}








