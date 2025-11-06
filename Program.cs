using System;

namespace Exam
{
    class Program
    {
        public static void Main()
        {
            const string MsgInput = "Enter the secret number: ";
            const string MsgOverflow = "Number entered too big.";
            const string MsgNotNumber = "Input is not a number";
            const string MsgNegative = "Number enteres is not positive";
            const string MsgError = "Unexpected error ocurred: {0}";
            const string MsgDoors = "{0} doors generated.";
            const string MsgDoorsOpen = "You can open doors: ";

            int number;
            string numstr;
            bool valid = false;

            var rand = new Random();

            number = 0;
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

            int door = rand.Next(5, 16);
            Console.WriteLine(MsgDoors, door);
            Console.Write(MsgDoorsOpen);
            for (int i = 1; i <= door; i++)
            {
                float divisionf = (float)i / (float)number;
                int divisionint = (int)divisionf;
                if (divisionf == divisionint)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}