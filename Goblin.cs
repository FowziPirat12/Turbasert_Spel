
using Turbasert_Spel;

namespace Turbasert_Spel2
{
    public class Goblin: Enemy
    {


        public Goblin (string name, int hp):base (name, hp)
        {
            
        }

        public void DealDamages(string target)
        {
            Console.WriteLine("Enemy deals " + damage + " damage to "  + target);
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