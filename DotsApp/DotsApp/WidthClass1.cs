using System;
using System.Collections.Generic;
using System.Text;

namespace DotsApp
{
    class LengthClass2: LengthClass1
    {
        private int length2;
        private int width2;

        public int length21
        {
            get { return length2; }
            set { length2 = value; }
        }

        public int width21
        {
            get { return width2; }
            set { width2 = value; }
        }

        public LengthClass2(int length21, int width21, int length, int width): base (length, width)
        {
            var peri = (length+width+length21+ width21);
            Console.WriteLine($"Your periemeter is {peri}");
        }
    }
}
