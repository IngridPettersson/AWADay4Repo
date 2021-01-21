//3. … som tar in data från en väderstation. Programmet ska fråga hur många mätningar som har
//                gjorts. Programmet ska sedan fråga efter mätdata, och skriva ut medeltemperaturen.

using System;

namespace AWADay4PracticeArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many temperature measurements have been done? ");
            int number = int.Parse(Console.ReadLine());

            double[] measurements = new double[number];
            double sum = 0;

            for (int i = 0; i < measurements.Length; i++)
            {
                Console.Write($"Add temperature (°C) for measurement {i + 1}: ");
                measurements[i] = double.Parse(Console.ReadLine());
                sum += measurements[i];
            }

            double averageTemp = Math.Round(sum / measurements.Length, 2);
            Console.WriteLine($"The average temperature is {averageTemp} °C");
        }
    }
}
