            /*
             Skapa en Console Application:
                1. … som skapar en string-vektor med fem element. Användaren får mata in fem namn via en
                for-loop. Programmet skriver sedan ut namnen i en annan for-loop i omvänd ordning.
                2. … lägg till funktionalitet till lösningen ovan för att byta ut ett namn på ett givet index.


             */
using System;

namespace AWADay4PracticeArrays
{
    class ProgramArrays
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Add a name: ");
                names[i] = Console.ReadLine();
            }

            Array.Reverse(names);
            Console.WriteLine("\nNames your array, in reversed order:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.Write($"\n{names[2]} has left us. Add a new person to {names[2]}s position: ");
            names[2] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your array with the new person: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
