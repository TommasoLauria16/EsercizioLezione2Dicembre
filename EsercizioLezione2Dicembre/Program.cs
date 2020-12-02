using System;
using LibreriaEs2_12;

namespace EsercizioLezione2Dicembre
{
    public class Program
    {
         static void Main(string[] args)
        {
            uint a = PariDispariIntervalo.LeggiIntero();
            uint b = PariDispariIntervalo.LeggiIntero();
            PariDispariIntervalo.PariDispari(a, b);
        }
        
    }
}
