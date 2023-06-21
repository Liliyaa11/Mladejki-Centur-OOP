using System.ComponentModel;

namespace Mladejki_Centur_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Брой младежи: ");
                int n = int.Parse(Console.ReadLine());
                List<Mladej> mladej = new List<Mladej>();

                //Въвежда данни за младежите в дадена организация
                Console.WriteLine("vavedi 1-za uchenik, 2-student, 3-rabotnik");
                int nomer = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            var danni = Console.ReadLine().Split();
                            Mladej uchenik = new Uchenik(danni[0], danni[1], danni[2], int.Parse(danni[3]));
                            mladej.Add(uchenik);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < n; i++)
                        {
                            var danni = Console.ReadLine().Split();
                            Mladej student = new Student(danni[0], danni[1], danni[2], danni[3], int.Parse(danni[4]));
                            mladej.Add(student);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < n; i++)
                        {
                            var danni = Console.ReadLine().Split();
                            Mladej rabotnik = new Rabota(danni[0], danni[1], danni[2], danni[3], danni[4], int.Parse(danni[5]));
                            mladej.Add(rabotnik);
                        }
                        break;
                }
            }

            catch (Exception)
            {

                
            }

        }
    }
}