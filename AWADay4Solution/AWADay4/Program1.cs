using System;

namespace AWADay4
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Skapa en Console Application med en metod:
            //1. … Addera() som tar två heltal och returnerar summan.
            //2. … Moms() som tar ett tal som inparameter och räknar ut momsen. Anta att moms är 25 %.
            //3. … Moms() som tar ett tal och moms och returnerar resultatet.
            //     

            int sum = AddTwoNumbers(2, 5);
            Console.WriteLine($"Total sum: {sum:C}\n");

            double VAT = CalculateVAT(100);
            Console.WriteLine($"VAT: {VAT:C}\n");

            Console.Write("Enter a price: ");
            int inputPrice = int.Parse(Console.ReadLine());

            Console.Write("Enter VAT as a decimal number: ");
            double inputVAT = double.Parse(Console.ReadLine());

            double VAT2 = CalculateVAT2(inputPrice, inputVAT);
            Console.WriteLine($"VAT: {VAT2:C}\n");
        }

        private static int AddTwoNumbers(int i, int j)
        {
            return i + j;
        }

        private static double CalculateVAT(int k)
        {
            return k * 0.25;
        }

        private static double CalculateVAT2(int number, double vat)
        {
            return number * vat;
        }


    }
}
