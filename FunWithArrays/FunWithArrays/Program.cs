using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = arraySize();
            int size = v;
            int[] vs = ArrayCreation(size);
            int[] mYrray = vs;

            ShowArray(mYrray, size);
            int[] b = ShowSpecialNumbers(mYrray, size);

            
            Console.WriteLine("Which way do you want to sort your Array?");
            SortingDecision(b);


            Console.ReadLine();
        }


        private static void SortingDecision(int[] fltrdRry)
        {
            bool flag = false;
            do
            {
                // use switch case:
                Console.WriteLine("Enter 'asc' or 'desc'");
                string sortingWay = Console.ReadLine();
                switch (sortingWay)
                {
                    case "asc":
                        Array.Sort(fltrdRry);
                        foreach (int n in fltrdRry)
                            Console.Write("{0}, ", n);
                        flag = true;
                        break;
                    case "desc":
                        Array.Sort(fltrdRry);
                        Array.Reverse(fltrdRry);
                        foreach (int n in fltrdRry)
                            Console.Write("{0}, ", n);
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Please enter either 'asc' or 'desc'");
                        break;
                }
            } while (!flag);
            //do
            //{
            //    const string asc = "asc"; // use Enum for asc adn Desc
            //    const string desc = "desc";
            //    Console.WriteLine("Enter 'asc' or 'desc'");
            //    string sortingWay = Console.ReadLine();

            //    if (sortingWay == asc)
            //    {
            //        Array.Sort(fltrdRry);
            //        foreach (int n in fltrdRry)
            //            Console.Write("{0}, ",n);
            //        flag = true;
            //    }
            //    else if (sortingWay == desc)
            //    {
            //        Array.Sort(fltrdRry);
            //        Array.Reverse(fltrdRry);
            //        foreach (int n in fltrdRry)
            //            Console.Write("{0}, ", n);
            //        flag = true;
            //    }

            //} while (!flag);
        }



        static int[] ArrayCreation(int size)
        {
            int[] array1 = new int[size];
            Console.WriteLine("Fill Array");
            for (int i = 0; i < size; i++)
            {
                // populate array in one line splitting by coma e.g. 3,5,6,7
                Console.WriteLine($"Please enter {i} array value from {size}");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array1;
        }

        static void ShowArray(int[] arr, int s)
        {
            int i;
            Console.WriteLine("Here is your array:");
            for (i = 0; i < s; i++)
            {
                Console.Write("{0},  ", arr[i]);
            }
            Console.WriteLine("Remove or finish.");
        }


        static int[] ShowSpecialNumbers(IReadOnlyList<int> arr, int s)
        {
            if (arr.Count == 0)
            {
                throw new ArgumentException("Array can not be null.");
            }
            int z = DivideFor();
            int i;
            int filteredSize = 0;
            Console.WriteLine("Here is your filtered array:");
            for (i = 0; i < s; i++)
            { 
                if ((arr[i] % z) == 0)
                {
                    Console.Write("{0}  ", arr[i]);
                    filteredSize++;
                }
            }
            int[] filteredArray = new int[filteredSize];
            int n = 0;
            for (i = 0; i < s; i++)
            {     
                if ((arr[i] % z) == 0)
                {
                    filteredArray[n] = arr[i];
                    n++;
                }
            }

            return filteredArray;
        }


        static int DivideFor()
        {
            Console.WriteLine("Enter number to divide");
            int y = Convert.ToInt32(Console.ReadLine());
            return y;
        }


        static int arraySize()
        {
            Console.WriteLine("Please enter array size");
            int y = Convert.ToInt32(Console.ReadLine());
            return y;
        }
    }
}
