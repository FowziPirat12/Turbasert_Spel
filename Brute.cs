using Turbasert_Spel;

namespace Turbasert_Spel2
{
    public class Brute: Enemy //Skapar klassen Brute som ärver från Enemy
    {
        private int damage = 10; //Private medlem för antal skada Brute gör

        public int Damage //Egesńskap för att få tillgång till skada
        {
            get {return damage;} //returnar skada
        }
        
        public Brute (string name, int hp): base (name, hp) //konstruktur för att skapa en ny Brute  med angivet namn och Hp, som anropar basklassen
        {
            
        }

        public void DealDamages(string target)  //Metod för att göra skada på en "target"
        {
            Console.WriteLine("Brute deals " + damage + " damage to "  + target); //Skriver ut meddelande att Goblin gör skada på target 
        }

        public override void TakeDamage (int Tdamage) ////Överskuggad metod för att hantera när Brute tar skada
        
        {
            Hp -= Tdamage; //Hp sjunker när Brute tar skada
        }

        public override void Print() //Överskuddad metod som skriver ut information om Brute
        {
            //Skriver ut Enemy Namn och Hp
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"HP: {hp}");
        } 
    }
}
