using Turbasert_Spel1;

namespace Turbasert_Spel
{
    public class Enemy: Character
    {

        public Enemy (string name, int hp): base (name, hp)
        {

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