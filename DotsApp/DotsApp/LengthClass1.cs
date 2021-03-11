using System;
using System.Collections.Generic;
using System.Text;

namespace DotsApp
{
    public class LengthClass1
    {
        private int length;
        private int width;

        public int Lenght
        {
            get { return length; }
            set { length = value; }
        }

        public int Widght
        {
            get { return width; }
            set { width = value; }
        }

        public LengthClass1 (int lenght, int widht)
        {
            var sqr = lenght * widht;
            Console.WriteLine($"Sqaure is : {sqr} square units");
        }
    }
}
