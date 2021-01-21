using System;
using System.Collections.Generic;
using System.Text;

namespace MerryMethodsProject
{
    class MethodBench
    {
        public void FirstMethod()
        {
            Console.WriteLine("Merry Methods");
        }

        public void SecondMethod(string msg)
        {
            Console.WriteLine(msg);
        }

        public void ThirdMethod(string msg, bool itIsTrue)
        {
            string userInput;

            if (itIsTrue)
                userInput = msg.ToUpper();
            else
                userInput = msg.ToLower();

            SecondMethod(userInput);
            Console.WriteLine();
        }

        public bool FourthMethod()
        {
            bool wantToShout = false;
            ConsoleKey inputKey;

            do
            {
                Console.Write("Would you like to [W]hisper or [S]hout? ");
                inputKey = Console.ReadKey().Key;
                Console.WriteLine();

                if (inputKey == ConsoleKey.W)
                    wantToShout = false;
                else if (inputKey == ConsoleKey.S)
                    wantToShout = true;

            } while (inputKey != ConsoleKey.W && inputKey != ConsoleKey.S);

            return wantToShout;
        }

        public (string Name, bool LengthyName) SixthMethod()
        {
            Console.Write("Enter a name of someone or something: ");
            string name = Console.ReadLine();
            bool lengthyName;
            if (name.Length > 5)
                lengthyName = true;
            else
                lengthyName = false;

            return (name, lengthyName);
        }
    }
}
