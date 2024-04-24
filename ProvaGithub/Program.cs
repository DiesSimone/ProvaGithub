using System.Runtime.InteropServices.Marshalling;

namespace ProvaGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++) 
            {
                Spam();
            }
        }
        public static void Spam()
        {
            Console.WriteLine("CIAO GITHUB!!!!!!!!!!!!!!!!!!!");
        }
    }
}
