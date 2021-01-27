using static System.Console;

namespace TimesTable
{
    public static class Times
    {
        public static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");

            for (int row = 1; row <= 10; row++ )
            {
                WriteLine($"{row} X {number} = {row * number}");
            }

            WriteLine();
        }

        public static void RunTimesTable()
        {
            bool isNumber;

            do
            {
                WriteLine("Enter a number between  0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if(isNumber)
                {
                   TimesTable(number) ;
                }
            
                else
                {
                    WriteLine("You entered an invalid number!");
                }
                
            }
            while(isNumber);
        }
    }
}