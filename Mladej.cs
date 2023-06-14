using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mladejki_Centur_OOP
{
    public abstract class Mladej:IPrint
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string adres;
        public string Adres
        {
            get { return adres; }
            set {  adres = value; }
        }
        private int godinaNaRajdane;
        public int GodinaNaRajdane
        {
            get { return godinaNaRajdane; }
            set { godinaNaRajdane = value; }
        }
        public Mladej(string ime, string adres, int godnarajdane)
        {
            this.Ime= ime;
            this.Adres=adres;
            this.GodinaNaRajdane= godnarajdane;
        }
        
        public abstract double SumAge();
        public virtual void Print() { }
    }
}
