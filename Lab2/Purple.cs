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
            int Task01(int n, int p, int h)
            {
                int s = 0;

                for (int i = 0; i < n; i++)
                {

                    int x = p + i * h;
                    s += x * x;

                }


                return s;
            }
            answer = Task01(n, p, h);

            // end


            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            (int, int) Task02(int a, int b)
            {
                int quotient = 0;
                int remainder = 0;


                while (a >= b)
                {
                    a -= b;
                    quotient++;

                }

                remainder = a;


                (int, int) ans = (quotient, remainder);

                return ans;
            }

            (int, int) answer = Task02(a, b);
            quotient = answer.Item1;
            remainder = answer.Item2;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            List<string> Task03()
            {

                List<(double, double, double)> answer = new List<(double, double, double)>();
                List<string> ans = new List<string>();
                List<double> znamenateli = new List<double> { };
                List<double> chisliteli = new List<double> { };

                // знаменатели
                List<double> sum = new List<double> { };
                List<double> first = new List<double> { };

                first.Add(1);
                first.Add(1);

                for (int i = 3; i < 30; i++)
                {
                    sum = first[(i - 3)..(i - 1)];

                    first.Add(sum.Sum());

                    if (i == 29)
                    {
                        foreach (int j in first)
                        {
                            znamenateli.Add(j);
                        }
                    }


                }


                // числители
                List<double> sum1 = new List<double> { };
                List<double> second = new List<double> { };

                second.Add(1);
                second.Add(2);

                for (int i = 3; i < 30; i++)
                {
                    sum1 = second[(i - 3)..(i - 1)];

                    second.Add(sum1.Sum());

                    if (i == 29)
                    {
                        foreach (int j in second)
                        {
                            chisliteli.Add(j);
                        }
                    }


                }


                var zipped = chisliteli.Zip(znamenateli, (num1, num2) => (num1 / num2, num1, num2));

                foreach (var item in zipped)
                {
                    answer.Add(item);
                }

                for (int i = 0; i <= answer.Count() - 2; i++)
                {
                    List<(double, double, double)> slice = answer[i..(i + 2)];

                    double r = Math.Abs(slice[0].Item1 - slice[1].Item1);
                    if (r < Math.Pow(10, (-4)))
                    {
                        ans.Add(string.Join(", ", r, slice[1].Item2 + "/" + slice[1].Item3));
                    }
                }



                return ans;
            }

            string[] h = Task03()[0].Split(", ");
            answer = double.Parse(h[1].Split("/")[0]) / double.Parse(h[1].Split("/")[1]);
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int Task04(double b, double q)
            {
                double r = Math.Pow(10, -4);

                List<double> progr = new List<double> { };

                int pow = 0;
                double curr = b;

                while (Math.Abs(curr) >= r)
                {
                    progr.Add(b * Math.Pow(q, pow));
                    pow += 1;
                    curr = progr[progr.Count - 1];
                }

                return progr.Count;

            }


            answer = Task04(b, q);
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            int Task05(int a, int b)
            {
                int answer = 0;
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

                return answer;
            }

            answer = Task05(a, b);
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            long Task06()
            {
                long ans = 0;
                double num = 0;

                for (long i = 0; i < 64; i++)
                {
                    num += Math.Pow(2, i);

                }

                ans = (long)Math.Floor((num / 15) * Math.Pow(10, (-6)));



                return ans;
            }

            answer = Task06();
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            int Task07(double S, double d)
            {
                double summa = S;
                int month = 0;
                double summa_ats = 0;

                while (summa < (2 * S))
                {
                    if (month == 0 || month % 12 == 0)
                    {
                        summa_ats = summa;
                    }

                    summa += (d / 1200) * summa_ats;
                    month++;
                }

                return month;

            }

            answer = Task07(S, d);
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            (double, double) Task08(double a, double b, double h)
            {

                double summaSumm = 0;
                double summaCos = 0;

                for (double x = a; x <= b + 0.0001; x += h)
                {
                    double last = 1;
                    double summa = 0;
                    int i = 0;

                    while (Math.Abs(last) >= 0.0001)
                    {
                        summa += last;
                        i++;
                        last = last * (-x * x) / ((2 * i - 1) * (2 * i));
                    }

                    summaSumm += summa;
                    summaCos += Math.Cos(x);

                }

                return (summaSumm, summaCos);

            }


            (double, double) Answer = Task08(a, b, h);
            SS = Answer.Item1;
            SY = Answer.Item2;

            // end

            return (SS, SY);
        }
    }
}