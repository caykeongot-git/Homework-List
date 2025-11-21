using System;

namespace Day_1
{
    class PhuongTrinhBac1
    {
        protected int a { get;set;}
        protected int b { get;set;}

        public PhuongTrinhBac1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calc ()
        {
            if (a == 0) return 0;
            return -b / (double)a;
        }
        
    }

}