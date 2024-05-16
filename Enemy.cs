using Turbasert_Spel1;

namespace Turbasert_Spel
{
    class Enemy: Character, IDamage
    {

        private int damage = 10;

        public int Damage
        {
            get {return damage;}
        }
        public Enemy (string name, int hp): base (name, hp)
        {
            
        }

        public void DealDamage(string target)
        {
            Console.WriteLine("Enemy deals " + Damage + " damage to"  + target);
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