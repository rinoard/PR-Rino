using System;
using System.Collections.Generic;
using System.Text;
using ExamBase;

namespace ExamHari05
{
    class PR1: LogicBase
    {
        public PR1(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = n*n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.Cetak(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(JmlhBaris * JmlhKolom);
            for (int bangun = 0; bangun < n; bangun++)
            {
                int angka = 1;
                int StartBaris = JmlhBaris -1-((bangun*bangun+bangun)/2);
                int StartKolom = bangun*bangun;
                int EndBaris = StartBaris -(bangun);
                int EndKolom = StartKolom + (bangun*2);
                for (int b = 0; b <= StartBaris ; b++)
                {
                    for (int k = StartKolom; k <= EndKolom; k++)
                    {
                        if(b+k>=StartKolom +StartBaris &&k-b<=EndKolom -StartBaris )
                        Array2D[b, k] = fibo[angka++].ToString();                        
                    }
                }

            }
        }
    }
}
