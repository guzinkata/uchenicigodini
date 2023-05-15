using System;

class Program
{
    static void Main()
    {
        Console.Write("Broi uchenici: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nUchenik {i}:");
            Console.Write("Godini: ");
            int godini = int.Parse(Console.ReadLine());
            Console.Write("Mesec: ");
            int mesec = int.Parse(Console.ReadLine());

            if (godini >= 14 && godini <= 18)
            {
                if (godini == 14)
                    Console.WriteLine("Uchenikut e v 8 klas.");
                else if (godini == 15)
                {
                    if (mesec > 9)
                        Console.WriteLine("Uchenikut e v 10 klas.");
                    else
                        Console.WriteLine("Uchenikut e v 9 klas.");
                }
                else if (godini == 16)
                {
                    if (mesec > 9)
                        Console.WriteLine("Uchenikut e v 11 klas.");
                    else
                        Console.WriteLine("Uchenikut e v 10 klas.");
                }
                else if (godini == 17)
                {
                    if (mesec > 9)
                        Console.WriteLine("Uchenikut e v 12 klas.");
                    else
                        Console.WriteLine("Uchenikut e v 11 klas.");
                }
                else
                {
                    if (mesec > 18)
                        Console.WriteLine("Uchenikut e zavurshil.");
                    else
                        Console.WriteLine("Uchenikut e v 12 klas.");
                }
            }
            else
            {
                Console.WriteLine("nevalidni godini.");
            }

            Console.WriteLine("godini: " + godini);
            Console.WriteLine("mesec: " + mesec);
            Console.WriteLine("------");
        }
    }
}
