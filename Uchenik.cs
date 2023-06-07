﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mladejki_Centur_OOP
{
    internal class Uchenik:Mladej
    {
        private string uchilishte;   
        public string Uchilishte
        {
            get { return uchilishte; }
            set { uchilishte = value;}
        }
        public Uchenik(string uchilishte,string ime, string adres, int godnarajdane) : base(ime, adres, godnarajdane)
        {
            this.Uchilishte = uchilishte;
        }
        public void Print()
        {
            Console.WriteLine($"Име:{this.Ime}, Адрес:{this.Adres}, Година на раждане:{this.GodinaNaRajdane}," +
                $" Училище:{this.Uchilishte}");
        }
        public override int Validation()
        {
            
        }

    }
}
