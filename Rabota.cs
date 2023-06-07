using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mladejki_Centur_OOP
{
    internal class Rabota:Mladej
    {

        public string Predpriqtie { get; set; }
        public string Specialnost { get; set; }
        public string Dlujnost { get; set; }
        public Rabota(string predpriqtie, string specialnost, string dlujnost, string ime, string adres, int godnarajdane) : base(ime, adres, godnarajdane)
        {
            this.Predpriqtie = predpriqtie;
            this.Specialnost = specialnost;
            this.Dlujnost = dlujnost;
        }

        public void Print()
        {
            Console.WriteLine($"Име:{this.Ime}, Адрес:{this.Adres}, Година на раждане:{this.GodinaNaRajdane}," +
                $"Предприятие:{this.Predpriqtie}, Специалност:{this.Specialnost}, Длъжност:{this.Dlujnost}");
        }
        public override int Validation()
        {

        }
    }
}
