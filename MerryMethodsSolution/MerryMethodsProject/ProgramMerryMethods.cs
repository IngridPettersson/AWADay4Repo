using System;

namespace MerryMethodsProject
{
    class ProgramMerryMethods
    {
        static void Main(string[] args)
        {
            MethodBench methodBench = new MethodBench();
            int i = 0;
            do
            {
                //Varför kan jag inte anropa metoden direkt från klassen utan måste gå via instansen?
                methodBench.FirstMethod();
                i++;
            } while (i < 3);

            methodBench.SecondMethod("\nC# Now and Forever!\n");

            Console.Write("Enter what's on your mind right now: ");
            string inputMsg = Console.ReadLine();

            methodBench.SecondMethod(inputMsg);
            Console.WriteLine();

            Console.Write("Press [U] to print in UPPER CASE and any other key for lower case: ");
            ConsoleKey inputKey = Console.ReadKey(true).Key;
            bool keyIsU;
            if (inputKey == ConsoleKey.U)
                keyIsU = true;
            else
                keyIsU = false;

            methodBench.ThirdMethod(inputMsg, keyIsU);
            Console.WriteLine();

            bool shout = methodBench.FourthMethod();
            methodBench.ThirdMethod(inputMsg, shout);
            methodBench.ThirdMethod(inputMsg, methodBench.FourthMethod());

            var returnFromNo6 = methodBench.SixthMethod();

            if (returnFromNo6.LengthyName == true)
                Console.WriteLine($"\"{returnFromNo6.Name}\" is a lengthy name.");
            else
                Console.WriteLine($"\"{returnFromNo6.Name}\" is a short name.");
        }
    }
}
