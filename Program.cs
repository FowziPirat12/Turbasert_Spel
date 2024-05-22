using System;
using System.Diagnostics;
namespace Turbasert_Spel;

class Program
{ 
    static void Main(string[]args)
    {
        //Skriver ut  spelaren och fienden i huvudprogrammet med deras namn och hur mycket HP de har. 
        Player player = new Player("Arthur", 100);
        Enemy enemy = new Enemy("Ultron",100);

        //Skapar en text som berättar vad det är för spel.
        Console.WriteLine("Detta är ett Turspel!");
        
        Random random = new Random();

       
       while (player.Hp >0 && enemy.Hp > 0)
       {
            Console.WriteLine("Välj en handling:");
            Console.WriteLine("1. Attackera fienden!");
            Console.WriteLine("2. Heal up!");
            int SpelarensVal = int.Parse(Console.ReadLine());

            switch (SpelarensVal)
            {
                case 1: 
                player.Print();
                Console.WriteLine();
                enemy.Print();
                Console.WriteLine();
                player.DealDamage(target: "Enemy");
                Console.WriteLine();
                enemy.TakeDamage(20);
                break;


            }

        }
        
    } 
}
