namespace Mladejki_Centur_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Mladej> mladej=new List<Mladej> ();
            try
            {
                //Въвежда данни за младежите в дадена организация
                Console.Write("Брой младежи: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Младеж: {mladej}");
                    Console.Write("Име: ");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}