
using Turbasert_Spel;

namespace Turbasert_Spel2
{
    public class Goblin: Enemy //Skapar en class som heter Goblin som ärver från Enemy
    {


        public Goblin (string name, int hp):base (name, hp) //konstruktur för att skapa en ny Goblin med angivet namn och Hp, som anropar basklassen
        {
            
        }

        public void DealDamages(string target) //Metod för att göra skada på en "target"
        {
            Console.WriteLine("Enemy deals " + damage + " damage to "  + target); //Skriver ut meddelande att Goblin gör skada på target 
        }

        public override void TakeDamage (int Tdamage) //Överskuggad metod för att hantera när Goblin tar skada
        {
            Hp -= Tdamage; //Hp minskar när Goblin tar skada
        }

        public override void Print() //Överskuddad metod som skriver ut information om Goblin
        {
            //Skriver ut Goblin nman och hp
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"HP: {hp}");
        } 
    }
}
