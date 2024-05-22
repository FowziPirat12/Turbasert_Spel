using System.Data;
using Turbasert_Spel1;

namespace Turbasert_Spel
{
     class Player: Character, IDamage
    {
        private int damage = 20;

        public int Damages
        {
            get {return damage;}
        }

        public void DealDamages(string target)
        {
            Console.WriteLine("Player deals " + Damage + " damage to"  + target);
        }

        public Player (string name, int hp): base(name, hp)
        {

        }

        public override void Print()
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