using System;
using System.Collections.Generic;
using System.Text;

namespace PRLogic01
{
    class PRLogic01_05
    {
        public PRLogic01_05()
        {
            int n = 9;
            for (int jb = 0; jb < n; jb++) //Baris
            {
                for (int jk = 0; jk < n; jk++)//Kolom
                {
                    if (jb == jk || jb + jk == (n - 1) || jb == 0 || jb == (n - 1) || jk == 0 || jk == (n - 1))
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }            
        }
    }
}
