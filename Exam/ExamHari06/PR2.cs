using System;
using System.Collections.Generic;
using System.Text;
using ExamBase;

namespace ExamHari06
{
    class PR2 : LogicBase
    {
        public PR2(int n)
        {
            JmlhBaris = 3 + (n - 1);
            JmlhKolom = n * 3 + (n * (n - 1) / 2);
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.Cetak(Array2D);
        }

        private void IsiArray(int n)
        {
            int deret = JmlhKolom;
            int angka = JmlhKolom;
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StKolom = (bangun *(3 + n - 1)) - (bangun * (bangun - 1) / 2);
                int StBaris = bangun;
                int EndBaris = n + 1;
                int EndKolom = StKolom + (5 - bangun);

                for (int b = StBaris; b <= EndBaris; b++)
                {
                    angka = deret;
                    for (int k = StKolom; k <= EndKolom; k++)
                    {
                        if (b + k == StBaris + EndKolom || b == StBaris || k == StKolom)
                        {
                            Array2D[b, k] = angka.ToString();
                        }
                        angka--;
                    }
                }
                deret = angka;
            }
        }
    }
}
