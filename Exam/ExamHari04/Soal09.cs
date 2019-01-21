using System;
using System.Collections.Generic;
using System.Text;
using ExamBase;

namespace ExamHari04
{
    class Soal09 : LogicBase
    {
        public Soal09(int n)
        {
            Console.Write("Masukan Jumlah Mirror : ");
            int m = int.Parse(Console.ReadLine());
            JmlhBaris = n;
            JmlhKolom = (n * m) - (m - 1);
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(m);
            FunctionBase.Cetak(Array2D);
        }

        private void IsiArray(int m)
        {
            for (int lm = 1; lm <= m; lm++)
            {

                for (int b = 0; b < JmlhBaris; b++)
                {
                    int angka = 1;
                    for (int k = 0; k < JmlhKolom; k++)
                    {
                        if (b + k >= JmlhBaris / 2 && k - b <= JmlhBaris / 2 && b <= JmlhBaris / 2)
                        {
                            Array2D[b, ((JmlhKolom - 1) / m) * lm - k] = angka.ToString();
                            Array2D[JmlhBaris - 1 - b, ((JmlhKolom - 1) / m) * lm - k] = angka.ToString();
                            if (k < JmlhKolom / (m * 2))
                                angka += 1;
                            else
                                angka -= 1;
                        }
                    }
                }
            }
        }
    }
}
