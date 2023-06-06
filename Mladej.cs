using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mladejki_Centur_OOP
{
    public abstract class Mladej
    {
        public string Ime { get; set; }
        public string Adres { get; set; }
        public int GodinaNaRajdane { get; set; }
        public Mladej(string ime, string adres, int godnarajdane)
        {
            this.Ime= ime;
            this.Adres=adres;
            this.GodinaNaRajdane= godnarajdane;
        }
        public abstract void DisplayInfo();
        public abstract int CalculateAge();
    }
}
