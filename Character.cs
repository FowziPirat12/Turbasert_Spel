namespace Turbasert_Spel1
{
    abstract class Character
    {
        protected string name;
        protected int hp; 

        private int damage = 10;

        public int Damage
        {
            get {return damage;}
        }

        public string Name 
        {
            get {return name;}
            set {name = value;}
        }

        public int Hp 
        {
            get {return hp;}
            set {value = hp;}
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
            Console.WriteLine("Player deals " + Damage + " damage to"  + target);
        }
 
    }
}