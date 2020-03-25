using System;

namespace NPCPerks
{
    class Program
    {
        enum NPC {
        Stealth,
        Combat,
        Lockpick,
        Luck
    }
        static void Main(string[] args)
        {
            int NPCs;
            NPC qualities;
            string[] properties;

            Console.WriteLine("Escreva o número de NPCs");
            while (!int.TryParse(Console.ReadLine(), out NPCs))
            {
                Console.WriteLine("Not a valid int");
                Console.WriteLine("Escreva o número de NPCs");
            }
            properties = new string[NPCs];
            for (int i = 0; i < NPCs; i++)
            {
                Console.WriteLine($"Escreva as características do {i+1}º NPC");
                properties[i] = Console.ReadLine();
                while (!Enum.TryParse<NPC>(properties[i], out qualities))
                {
                    Console.WriteLine("Característica inválida");
                    Console.WriteLine($"Escreva as características do {i+1}º NPC");
                    properties[i] = Console.ReadLine();
                }
            }
            for (int j = 0; j < NPCs; j++)
            {
                Console.WriteLine($"As características do {j+1}º NPC são: {properties[j]}");
                if (properties[j].Contains("Combat") && properties[j].Contains("Luck"))
                {
                    Console.WriteLine("You shall win all fights!");
                }
            }

        }
    }
}
