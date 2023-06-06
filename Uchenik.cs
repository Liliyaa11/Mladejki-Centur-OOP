using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mladejki_Centur_OOP
{
    internal class Uchenik:Mladej
    {
        public string Uchilishte { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Име:{this.Ime}, Адрес:{this.Adres}, Година на раждане:{this.GodinaNaRajdane}, Училище:{this.Uchilishte}");
        }
        public override int CalculateAge()
        {
            
        }

    }
}
