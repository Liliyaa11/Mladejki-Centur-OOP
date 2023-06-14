using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mladejki_Centur_OOP
{
    internal class Rabota:Mladej
    {
        private string predpriqtie;
        public string Predpriqtie
        {
            get { return predpriqtie; } 
            set { predpriqtie = value; }
        }
        private string specialnost;
        public string Specialnost
        {
            get { return specialnost; }
            set { specialnost = value; }
        }
        private string dlujnost;
        public string Dlujnost
        {
            get { return dlujnost; }
            set { dlujnost = value; }
        }

        public Rabota(string predpriqtie, string specialnost, string dlujnost, string ime, string adres, int godnarajdane) : base(ime, adres, godnarajdane)
        {
            this.Predpriqtie = predpriqtie;
            this.Specialnost = specialnost;
            this.Dlujnost = dlujnost;
        }

        public override void Print()
        {
            Console.WriteLine($"Име:{this.Ime}, Адрес:{this.Adres}, Година на раждане:{this.GodinaNaRajdane}," +
                $"Предприятие:{this.Predpriqtie}, Специалност:{this.Specialnost}, Длъжност:{this.Dlujnost}");
        }
        public override double SumAge()
        {
            int age = 2023 - GodinaNaRajdane;
            double sum = 0;
            sum += age;
            return sum;
        }

    }
}
