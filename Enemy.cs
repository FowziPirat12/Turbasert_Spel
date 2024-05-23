using Turbasert_Spel1;

namespace Turbasert_Spel
{
    public class Enemy: Character //Skapar en class Enemy som ärver från Character
    {

        public Enemy (string name, int hp): base (name, hp) //konstruktur för att skapa en ny Enemy  med angivet namn och Hp, som anropar basklassen
        
        {

        }

        public override void TakeDamage (int Tdamage) //Överskuggad metod för att hantera när Enemy tar skada
        {
            Hp -= Tdamage; //Hp minskar när Enemy tar skada
        }

        public override void Print() //Överskuddad metod som skriver ut information om Enemy
        {
            //Skriver ut Enemy Namn och Hp
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"HP: {hp}");
        }   
    }
}
