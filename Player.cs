using System.Data;
using Turbasert_Spel1;

namespace Turbasert_Spel
{
     class Player: Character //Skapar en klass Player som ärver från Klassen Character
    {

        public Player (string name, int hp): base(name, hp) //konstruktur öfr att skapa en ny spelare med namn och HP som förbinder sig till basklassen
        {

        }

        public override void Print() //Överskuggad information som skriver om spelaren
        {
            Console.WriteLine($"Name: {name}"); // Spelarens namn
            Console.WriteLine($"HP: {hp}"); //Spelaren HP
        }

        public override void TakeDamage(int Tdamage) //Överskuggad metod för att hantera spelaren tat skada
        {
            Hp -= damage;  // HP sjunker när spelaren tar skada
             // Skriver ut meddelande om att spelaren tar skada och deas nuvarande hp
            Console.WriteLine($"{name} takes damage!");
            Console.WriteLine($"{name} current health: {hp}");
        }

        

    }
}
