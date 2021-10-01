using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace MethodExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
        }
        public static void Exercise1()
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your favourite color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Which your favourite animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter your best musical band: ");
            string band = Console.ReadLine();

            Console.WriteLine($"My name is {name},i like {color} tshirt mostly,i love {animal} and kept at my home.I usually listen my best {band} music.");
        }
    }

    


}
