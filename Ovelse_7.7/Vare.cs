using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse_7._7
{
    internal class Vare
    {
        public string? VaresNavn {  get; set; }
        public double VaresPris { get; set; }

        public void Udskriv()
        {
            Console.WriteLine($"{VaresNavn}: {VaresPris:C2}");
        }
    }
}
