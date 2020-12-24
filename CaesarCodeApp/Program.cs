using CaesarCipherLibrary;
using System;

namespace CaesarCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la parola: ");
            string plaintext = Console.ReadLine();

            int key;
            CaesarCode ml;

            try
            {
                do
                {
                    Console.WriteLine("Inserisci la chiave");
                    key = Convert.ToInt32(Console.ReadLine());
                } while (key < 0 || key > 25);

                ml = new CaesarCode(plaintext, key);
                Console.WriteLine($"Il testo cifrato è: {ml.CipherText}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
