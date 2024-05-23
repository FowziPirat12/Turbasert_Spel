using System.Data;
using Turbasert_Spel1;

namespace Turbasert_Spel
{
     class Player: Character //Skapare en klass Player som ärver från Klassen Character
    {

        public Player (string name, int hp): base(name, hp) //konstruktur öfr att skapa en ny spelare med namn och HP som förbinder sog till basklassen
        {

        }

        public override void Print() //
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"HP: {hp}");
        }

        public override void TakeDamage(int Tdamage)
        {
            Hp -= damage; 
            Console.WriteLine($"{name} takes damage!");
            Console.WriteLine($"{name} current health: {hp}");
        }

        

    }
}