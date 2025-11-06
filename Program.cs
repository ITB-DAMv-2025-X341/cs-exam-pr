using System;

namespace Exam
{
    class Program
    {
        public static void Main()
        {
            const string MsgInput = "Enter a number (0 to exit): ";
            const string MsgDividers = "The divider numbers of {0} are: ";
            const string MsgExit = "Exiting program";

            int number, inc, divisorInt;
            string numstr;
            float divisor;
            do
            {
                do
                {
                    Console.Write(MsgInput);
                    numstr = Console.ReadLine();
                } while (!int.TryParse(numstr, out number));
                if (number != 0)
                {
                    Console.Write(MsgDividers, number);
                    inc = 1;
                    while (inc <= number)
                    {
                        divisor = (float)number / (float)inc;
                        divisorInt = (int)divisor;
                        if (divisor == divisorInt)
                        {
                            Console.Write(inc + " ");
                        }
                        inc++;
                    }
                    Console.WriteLine();
                } 
            } while (number != 0);
            Console.WriteLine(MsgExit);
        }
    }
}