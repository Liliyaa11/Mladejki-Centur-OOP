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
        public override void DisplayInfo()
        {
            Console.WriteLine($"Име:{this.Ime}, Адрес:{this.Adres}," +
                $" Година на раждане:{this.GodinaNaRajdane}, Факултет:{this.Fakultet}, Специалност:{this.Specialnost});
        }
    }
}
