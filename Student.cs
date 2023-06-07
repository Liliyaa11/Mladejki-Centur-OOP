using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mladejki_Centur_OOP
{
    internal class Student:Mladej
    {

        public string Fakultet { get; set; }
        public string Specialnost { get; set; }
        public Student(string fakultet, string Specialnost, string ime, string adres, int godnarajdane) : base(ime, adres, godnarajdane)
        {
            this.Fakultet = fakultet;
            this.Specialnost = Specialnost;
        }

        public override void Print()
        {
            Console.WriteLine($"Име:{this.Ime}, Адрес:{this.Adres}," +
                $" Година на раждане:{this.GodinaNaRajdane}, Факултет:{this.Fakultet}, Специалност:{this.Specialnost});
        }
        public override int Validation()
        {
            
        }
    }
}
