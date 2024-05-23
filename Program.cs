using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Turbasert_Spel2;
namespace Turbasert_Spel;

class Program
{ 
    static void Main(string[]args)
    {
        //Skriver ut  spelaren och fienden i huvudprogrammet med deras namn och hur mycket HP de har. 
        Player player = new Player("Arthur", 100); //Ger spelaren namn och HP
        Enemy enemy = new Enemy("Ultron",100); //Ger fienden namn och HP
        List<Enemy> enemies = new List<Enemy>(); //Skapar en lista 
        enemies.Add(new Brute("Baron",150)); //Lägger till fiender som ärver från Enemy
        enemies.Add(new Goblin("Gunther",50));
        
        

        //Skapar en text som berättar vad det är för spel.
        Console.WriteLine("Detta är ett Turspel!");
        
        Random random = new Random(); //Skapar en random metod för fienden

       
       while (player.Hp > 0 && enemy.Hp > 0) //En loop där spelaren och fiendes HP blir 0 ska spelet avslutas
       {
            Console.WriteLine("Välj en handling:"); //Text som förklarar vad för spel det är
            Console.WriteLine("1. Attackera fienden!"); // Olika val 
            Console.WriteLine("2. Heal up!");
            System.Console.WriteLine(); 
            int SpelarensVal = int.Parse((Console.ReadLine())); //Spelaren bestämer vilket val hen vill göra
            System.Console.WriteLine();

            switch (SpelarensVal) //Hanterar spelarens val
            {
                case 1: 
                //Om spelaren väljer att attackera
                player.Print(); //Spelarens status
                Console.WriteLine(); 
                enemy.Print(); //fiendens status
                Console.WriteLine();
                player.DealDamage(target: " Enemy"); //Spelaren attakcerar fienden
                Console.WriteLine(); 
                enemy.TakeDamage(20); //fienden tar skada
                System.Console.WriteLine();
                enemy.Print(); 
                break; //här tar det stopp

                //Om spelaren väljer att läka sig
                case 2:
                int healthAmount = random.Next(5, 6); //Slumpmässigt värde för läkning
                player.Hp += healthAmount; // ökar spelaren HP med slumpmässiga värdet

                if(player.Hp > 100) //Ser till att spelaren HP inte överstiger 100
                {
                    player.Hp = 100;
                }
                Console.WriteLine($"Spelaren läker sig själv: {player.Hp}");
                
                break;
                deafault: 
                Console.WriteLine("Ogiltig tal. Du förlorade din tur!"); // Om spelaren har valt en ogiltig alterntiv
            }

            if (enemy.Hp <= 0) //kontrolerar om fienden är besegrad
            {
                Console.WriteLine("Du har besegrat fienden!!!");
                break;
            }
            
            System.Console.WriteLine();

            Console.WriteLine("Fiendens tur");
            int FiendesnVal = random.Next(1,3); //Slumpmässigt val för fienden

            switch (FiendesnVal)
            {
                case 1: 
                enemy.Print();
                Console.WriteLine();
                player.Print();
                Console.WriteLine();
                enemy.DealDamage(target: " Spelare"); // Fienden attackerar  spelaren
                Console.WriteLine();
                player.TakeDamage(30); // Spelaren tar skada
                System.Console.WriteLine();
                player.Print();
                break;

                //Om fienden ska läka
                case 2: 
                int healthAmount = random.Next(1, 6);
                enemy.Hp += healthAmount;
                if(enemy.Hp > 100)
                {
                    player.Hp = 100;
                }
                Console.WriteLine($"Fienden läker sig själv: {player.Hp}");
                break;
            }

            if (player.Hp <= 0) //Kontrollerar spelaren HP
            {
                Console.WriteLine("Fienden har vunnit!!!");
                break;
            }

            System.Console.WriteLine();

        }

        System.Console.WriteLine("Spelet är slut");

        static void saveScore(string winner, int remeiningHp) // sparar spelets resultat i en fil
        {
            string filepath = "score.txt"; //filvägen där resultatet sparas
            using (StreamWriter sw = new StreamWriter(filepath, true)) // öppnar fieln till ett tillägsläge, using gör så att filen stängs och frigör resurser
            {
                sw.Write($"Current: {winner}, {remeiningHp}"); //Skriver ut vinnaren och hur mycket HP som var kvar
            }
        }
        
    } 
}
