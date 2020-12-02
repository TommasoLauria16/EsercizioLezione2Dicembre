using System;

namespace LibreriaEs2_12
{
    public class PariDispariIntervalo
    {
        public static uint LeggiIntero()
        {
            Console.Write("inserisci un numero intero positivo: ");
            uint a = uint.Parse(Console.ReadLine());
            return a;
        }
        public static void PariDispari(uint a, uint b)
        {
            int countP = 0, countD = 0;
            uint max = Math.Max(a, b);
            uint min = Math.Min(a, b);
            for (uint i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}-pari;");
                    countP++;
                }
                else
                {
                    Console.WriteLine($"{i}-dipari;");
                    countD++;
                }
            }
            Console.WriteLine($"i numeri pari sono: {countP};\ni numeri dispari: {countD}.");
        }
    }
}
