using System;

namespace Binary_search
{
    class Program
    {
        static int BinaryIntSearch(int[] MyArray, int Target)
        {
            int lBound = 0, uBound = MyArray.Length, MidPoint = 0;
            bool Found = false;
            while (Found == false && lBound<=uBound)
            {
                MidPoint = (lBound + uBound) / 2;
                if (MyArray[MidPoint] == Target)
                {
                    Found = true;
                }
                if (MyArray[MidPoint] > Target)
                {
                    uBound = MidPoint - 1;
                }
                else
                {
                    lBound = MidPoint + 1;
                }
            }
            if (Found == true)
            {
                return MidPoint;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("f");
            int[] Ages = {4, 34, 54, 23, 16, 53, 8};
            int pos;
            //
            pos = BinaryIntSearch(Ages, 4);
            if (pos == -1)
            {
                Console.WriteLine("Not in array");
            }
            else
            {
                Console.WriteLine("Item in position: " + Convert.ToString(pos));
            }

        }
    }
}
