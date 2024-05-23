namespace Turbasert_Spel1
{
    public abstract class Character
    {
        protected string name;
        protected int hp; 

        protected int damage = 20;

        public int Damage
        {
            get {return damage;}
            set {damage = value;}
        }

        public string Name 
        {
            get {return name;}
            set {name = value;}
        }

        public int Hp 
        {
            get {return hp;}
            set {hp = value;}
        }

        

        public Character (string name, int hp)
        {
            this.Name = name; 
            this.Hp  = hp;
        }

        public abstract void Print();
        public abstract void TakeDamage (int Tdamage);

        public void DealDamage(string target)
        {
            Console.WriteLine("Player deals " + damage + " damage to"  + target);
        }
 
    }
}