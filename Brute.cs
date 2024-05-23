using Turbasert_Spel;

namespace Turbasert_Spel2
{
    public class Brute: Enemy
    {
        private int damage = 10;

        public int Damage
        {
            get {return damage;}
        }
        public Brute (string name, int hp): base (name, hp)
        {
            
        }

        public void DealDamages(string target)
        {
            Console.WriteLine("Brute deals " + damage + " damage to "  + target);
        }

        public override void TakeDamage (int Tdamage)
        {
            Hp -= Tdamage; 
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"HP: {hp}");
        } 
    }
}