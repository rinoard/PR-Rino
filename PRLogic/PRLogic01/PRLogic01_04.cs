using System;
using System.Collections.Generic;
using System.Text;

namespace PRLogic01
{
    class PRLogic01_04
    {
        public PRLogic01_04()
        {
            int n = 9;            
            for (int jb = 0; jb < n; jb++) //Baris
            {
                for (int jk = 0; jk < n; jk++)//Kolom
                {
                    if (jb == jk || jb + jk == (n - 1) || jb == (n/2) || jk== (n/2))
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
