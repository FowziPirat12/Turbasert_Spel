namespace Turbasert_Spel
{
    public class Player
    {
        protected string name;
        protected int hp; 

        public string Name 
        {
            get {return name;}
            set {name = value;}
        }

        public Player (string name, int hp)
        {
            this.name = name; 
            this.hp  = hp;
        }
 



    }
}