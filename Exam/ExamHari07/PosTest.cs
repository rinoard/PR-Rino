using System;
using System.Collections.Generic;
using System.Text;
using ExamBase;

namespace ExamHari07
{
    class PosTest : LogicBase
    {
        public PosTest(int n)
        {
            JmlhBaris = n * n;
            JmlhKolom = JmlhBaris;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.Cetak(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(JmlhBaris  * JmlhKolom );
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int angka = 0;
                        int nAngka = n * 2 + (n - 2) * 2 - 1;
                        int StBaris = bb * n;
                        int StKolom = bk * n;
                        int EndBaris = StBaris + n - 1;
                        int EndKolom = StKolom + n - 1;

                        for (int b = StBaris; b <= EndBaris; b++)
                        {
                            for (int k = StKolom; k <= EndKolom; k++)
                            {
                                if (b == StBaris || k == EndKolom)
                                    Array2D[b, k] = fibo[angka++].ToString();
                                else if (b == EndBaris || k == StKolom)
                                    Array2D[b, k] = fibo[nAngka--].ToString();
                            }

                        }
                    }
                }
            }
        }
    }
}
