using System;

namespace Exam
{
    class Program
    {
        public static void Main()
        {
            const string MsgInput = "Enter a number (0 to exit): ";
            const string MsgOverflow = "Number entered too big.";
            const string MsgNotNumber = "Input is not a number";
            const string MsgNegative = "Number enteres is not positive";
            const string MsgError = "Unexpected error ocurred: {0}";
            const string MsgDividers = "The divider numbers of {0} are: ";
            const string MsgExit = "Exiting program";

            int number, inc, divisorInt;
            string numstr;
            float divisor;
            bool valid = false;
            number = 0;
            do
            {
                do
                {
                    Console.Write(MsgInput);
                    numstr = Console.ReadLine();

                    try
                    {
                        number = int.Parse(numstr);
                        if (number < 0)
                        {
                            Console.WriteLine(MsgNegative);
                        } else
                        {
                            valid = true;
                        }
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine(MsgOverflow);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(MsgNotNumber);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(MsgError, e);
                    }
                } while (!valid);
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