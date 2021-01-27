using System;
namespace ArrayUtility
{
    public static class Array
    {
        public static int[] Reverse (int[] arr)
        {
          for (int i = 0 ; i < arr.Length / 2; i++)
          {
              int temp = arr[i];
              arr[i] = arr[arr.Length - 1 - i];
              arr[arr.Length - 1 - i] = temp;
          }

          return arr;
        }

        public static int[] Descending(int[] arr)
        {
            int temp;

            for(int i = 0 ; i < arr.Length-1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    
                    if (arr[i] <  arr[j])
                    {   temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static void PrintToConsole(int[] arr)
        {
            foreach(int num in arr)
            {
                Console.WriteLine(num);
            }
        }
   
   
   
   
   
   
   
   
   
   
   
   
   
    }

    
}