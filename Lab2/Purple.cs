using System.Diagnostics;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;

        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here

            static int Square(int x) => x * x;

            for (var i = 0; i < n; i += 1) answer += Square(p + i * h); // Обладатель "Инкремент Hater Platinum Card"

            // end

            return answer;
        }

        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            remainder = a;

            // >:P
            MyC00lDivmModProcBtw_Start:

            if (remainder < b) goto MyC00lDivmModProcBtw_End;

            quotient += 1; // Являюсь обладателем "Инкремент++ Hater Platinum Card"
            remainder -= b;

            if (remainder >= b) goto MyC00lDivmModProcBtw_Start;

            MyC00lDivmModProcBtw_End:

            // end

            return (quotient, remainder);
        }

        public double Task3()
        {
            double answer = 0;

            // code here

            static double CalcFraction((int numerator, int denumerator) frac) =>
                frac.numerator / (double)frac.denumerator;

            (int numerator, int denumerator) previous = (1, 1), current = (2, 1), next;

            double difference;

            do
            {
                next.numerator = previous.numerator + current.numerator;
                next.denumerator = previous.denumerator + current.denumerator;

                difference = Math.Abs(CalcFraction(next) - CalcFraction(current));

                previous = current;
                current = next;
            } while (difference >= E);

            answer = CalcFraction(current);

            // end

            return answer;
        }

        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here

            double a = 1;

            for (answer = 1; Math.Abs(b * a) >= E; answer += 1) a *= q; // btw ++ Hater Platinum Card

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
                b -= 1; // -- Lord Hater Platinum Card btw
            }

            while (number >= 10)
            {
                number /= 10;
                answer += 1; // ++ Hater Sliver Card btw
            }

            // end

            return answer;
        }

        public long Task6()
        {
            long answer = 0;

            // code here

            var s = ulong.MaxValue;

            s /= 1000;
            s /= 1000;
            s /= 15;
            // >:P

            answer = (long)s;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            var target = 2.0 * S;
            var current = S;

            while (current < target)
            {
                var need = 1200.0 * (target - current) / (current * d);

                if (need <= 12.0)
                {
                    answer += (int)Math.Ceiling(need);
                    break;
                }

                current *= 1.0 + d / 100.0;
                answer += 12;
            }

            // end

            return answer;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            var n = (int)Math.Floor((b - a) / h + 1e-12);
            for (var k = 0; k <= n; k += 1) // >:P Инкремент++ Хейтер 101 Платинум карт
            {
                var x = a + k * h;
                var t = 1.0;
                for (var i = 0;; i += 1)
                {
                    if (Math.Abs(t) < E) break;
                    SS += t;
                    var f = -(x * x) / ((2.0 * i + 1) * (2.0 * i + 2));
                    t *= f;
                }

                SY += Math.Cos(x);
            }

            // end

            return (SS, SY);
        }
    }
}