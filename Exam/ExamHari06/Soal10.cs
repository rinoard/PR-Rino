using System;
using System.Collections.Generic;
using System.Text;
using ExamBase;

namespace ExamHari06
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            FunctionBase.Cetak(Array2D);
        }

        private void IsiArray()
        {
            bool kanan = true;
            int angka = 1;
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    if (b >= k)
                    {

                        if (kanan)
                        {
                            Array2D[b, k] = angka.ToString();
                        }
                        else
                        {
                            Array2D[b, JmlhKolom - 1 - k] = angka.ToString();
                        }
                    }
                }
                kanan = !kanan;
                angka++;
            }
        }
    }
}
