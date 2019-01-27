using System;
using System.Collections.Generic;
using System.Text;
using ExamBase;

namespace ExamHari07
{
    class Soal09: LogicBase
    {
        public Soal09(int n)
        {             
            JmlhBaris = n * n;
            JmlhKolom = n * n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.Cetak(Array2D);

        }

        private void IsiArray(int n)
        {
            int angka = 1;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if(bb==0 || bk==0 || bb==n -1 || bk==n - 1)
                    {
                        int StBaris = bb*n;
                        int StKolom = bk*n;
                        int EndBaris = StBaris + n - 1;
                        int EndKolom = StKolom + n - 1;

                        for (int b = StBaris ; b <= EndBaris ; b++)
                        {
                            for (int k = StKolom ; k <= EndKolom ; k++)
                            {
                                if(b-StBaris >=k-StKolom )
                                {
                                    Array2D[b, k] = angka.ToString ();
                                }
                            }
                        }
                    angka++;
                    }
                }
            }
        }
    }
}
