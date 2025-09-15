using System.Collections.Generic;
using System.ComponentModel;
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
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / (pow);
                pow *= x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            long fac = 1;
            // code here
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
                pow *= -5;
                //for (int j = 2; j <= i; j++)
                //    {
                //    fac *= j;
                //    }
                answer += pow / fac;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n <= 0) return 0;
            if (n == 1) return 0;

            long c1 = 0;
            long c2 = 1;
            answer = 1;
            //Здесь сразу пропускаю один ход потому что в любом случае у нас 1 + 0 = 1, то есть уже учтено.
            for (int i = 2; i < n; i++)
            {
                long ch = c1 + c2;
                //делаем сумму
                answer += ch;
                //добавляем
                c1 = c2;
                //последнее число становится 1
                c2 = ch;
                //а новое последнее число это сумма предыдущих так что бим бим бам бам бэм

            }


            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            if (L < a)
                return 0;

            long sum = 0;
            int n = 0;
            //считаем члены прогрессии
            while (sum <= L)
            {
                n += 1;
                sum += a + ((n - 1) * h);
            }
            answer = n - 1;
            // -1 тк последний ход превысил лимит (без этого цикл не остановится)

            //2 вариант через формулу ариф прогрессии
            // Формула суммы арифметической прогрессии: S = n/2 * (2a + (n-1)h)
            // Решаем неравенство: n/2 * (2a + (n-1)h) <= L

            //int n = 0;
            //bool factor = true
            //while (factor)
            //{
            //    n+=1;
            //    long sum = n * (2L * a + (n - 1) * h) / 2;
            //    if (sum > L)
            //    {  
            //          factor = false  
            //          return n - 1;
            //     }
            //}




            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
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
            /*В метод передаются целые числа h, S, L. Одноклеточная амеба каждые h часов делится на 2
клетки.Определить через какое время в замкнутом объеме будет находиться не менее L клеток,
если первоначально в замкнутом объеме находилось S клеток.*/

            // code here

            while (S < L)
            {
                answer += h;
                S *= 2;
            }
            //Зачем так много текста, я испугалась :(

            // end

            return answer;
        }

        /*В метод передаются вещественные числа S и I. Начав тренировки, спортсмен в первый день
пробежал S км. Каждый следующий день он увеличивал дневную норму на I % от нормы
предыдущего дня.Определить:
a.какой суммарный путь пробежит спортсмен за 7 дней;
            b.через сколько дней спортсмен пробежит суммарный путь 100 км;
            c.через сколько дней спортсмен будет пробегать в день больше 42 км ?*/
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            //начнем с бредика А
            double sa = S;
            a += S;
            for (int day = 2; day <= 7; day++)
            {
                sa = sa * (1 + I / 100);
                a += sa;
            }
            // дальше идем Б
            double sb = S;
            double sumB = S;
            b = 1;
            while (sumB < 100)
            {
                sb = sb * (1 + I / 100);
                sumB += sb;
                b += 1;
            }
            //дейлик с
            double sc = S;
            c = 0;
            while (sc <= 42)
            {
                sc = sc * (1 + I / 100);
                c += 1;
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
            for (double x = a; x <= b + 1e-10; x += h) //1e-10 я нашла в интернете, как там писалось, это помогает убрать ошибки при малых значениях(мне помогло реально)
            {
                double sum = 0; //сумма для нашего нынешнего х
                int i = 0; //номер х-бро +++ возвращаясь к факториалам(дальше по решению), если мы берем факториал от 0 то получаем 1 поэтому у нас это не учитывается ибо у нас на 1 идет деление и да
                double broo; //текущий член-бро (по формулке это s) ряда
                double factorial = 1;//начинаем с 1 потому что да, минимальный челик
                //вычислим ряд для нашего х
                double x_pow = 1;
                double x_sq = x * x;
                do
                {
                    if (i > 0)//защита чтоб у нас весь факториал по нулю не пошел (факториала равного нулю нету)
                    {
                        factorial *= i; //подсчитываем факториал для текущего (прошлый факториал в этом случае уже учитывается ибо получается что прошлый факториал домножается на нынешнее чиселко и выходит новый факториал так что доп функция для счета факториала не нужна
                        x_pow *= x_sq;
                    }
                    broo = (2 * i + 1) * x_pow / factorial;
                    sum += broo;
                    i += 1;
                }
                while (broo >= epsilon);

                // аналит функция с у
                double y = (1 + 2 * x * x) * Math.Exp(x * x); //просто переписываем и используем блага c# с его экспанентой встроенной
                SS += sum;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}
