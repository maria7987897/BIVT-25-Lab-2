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
            long answer = 1;
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

            if otric 
            {
                answer = 1.0 / answer;
            }
      
            // end
            return answer;
        }






        
        public int Task5(int L)
        {
            int answer = 0;
            // code here
            
            // end
            return answer;
        }







        
        public double Task6(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }

        





        

        public int Task7(int n)
        {
            int answer = 0;
            // code here
            int sum = 0;
            int n;
            for(int n = 0; sum < n; n++)
            {
                answer++;
                sum+=answer;
            }
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






