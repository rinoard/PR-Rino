using System;
using System.Collections.Generic;
using System.Text;
using ExamBase;

namespace ExamHari07
{
    class PR2:LogicBase 
    {
        public PR3(int n)
        {
            JmlhBaris = n * 2 + 1;
            JmlhKolom = n * 2 + (n * 2 - 1);
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.Cetak(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {

                int StKolom = bangun * 2;

                int EndBaris = JmlhBaris - 1 - bangun * 2;
                int EndKolom = JmlhKolom - 1 - StKolom;
                int angka = 1;
                int nAngka = (EndBaris) * 2 + (EndKolom - StKolom) + 1;
                for (int b = 0; b <= EndBaris; b++)
                {
                    for (int k = StKolom; k <= EndKolom; k++)
                    {
                        if (b == EndBaris || k == StKolom)
                            Array2D[b, k] = "" + angka++;
                        else if (k == EndKolom)
                        {
                            Array2D[b, k] = "" + nAngka--;
                        }
                    }
                }
            }
        }
    }
}
