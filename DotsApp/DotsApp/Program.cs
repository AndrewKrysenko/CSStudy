using System;

namespace DotsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter AB");

            int ab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter BC");
            int bc = Convert.ToInt32(Console.ReadLine());



            LengthClass1 square = new LengthClass1(ab, bc);


            Console.WriteLine("Enter CD");

            int cd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter DA");

            int da = Convert.ToInt32(Console.ReadLine());


            LengthClass2 periemeter = new LengthClass2(ab, bc, cd, da);

            Console.ReadLine();
        }
    }
}
