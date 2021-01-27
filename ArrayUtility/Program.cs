using System;

namespace ArrayUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arNums = new int[] {1,100,4,5,300,10};

            //arNums = Array.Reverse(arNums);
            
            arNums = Array.Descending(arNums);

            arNums = Array.Reverse(arNums);

            Array.PrintToConsole(arNums);

        }
    }
}
