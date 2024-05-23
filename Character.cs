namespace Turbasert_Spel1
{
    public abstract class Character //Definerar en abstract baskklas som representerar en karaktär i spelet
    {
        protected string name; //Skyddad medlemm för karaktärns namn
        protected int hp; //Skyddad medlemm för karaktärns hp
        protected int damage = 20; //Skyddad medlemm för karaktärns skada

        public int Damage //Egenskapen för att få tillgång till och ändra skada hos en karaktär
        {
            get {return damage;} //returnerar skada 
            set {damage = value;} //Ger skada en value
        }

        public string Name //Egenskapen för att få tillgång till och ändra namn hos en karaktär
        {
            get {return name;} //returnerar namn
            set {name = value;} //ger namn en value
        }

        public int Hp //Egenskapen för att få tillgång till och ändra hp hos en karaktär
        {
            get {return hp;} //returnerar hp
            set {hp = value;} //ger hp en value
        }

        

        public Character (string name, int hp) //Konstruktur för att skapa en ny karaktär med angivet namn och hp
        {
            this.Name = name; //Tilldelade den angivna namn till karaktärens namn
            this.Hp  = hp; //Tilldelade den angivna hp till karaktärens hälsa
        }

        public abstract void Print(); //Abstract metod för att skriva ut information om karaktären
        public abstract void TakeDamage (int Tdamage); //Abstract metod för att hantera när spelaren tar skada

        public void DealDamage(string target)  //Metod för att göra skada på en "target"
        {
            Console.WriteLine("Player deals " + damage + " damage to"  + target); //Skriver ut meddelande att Spelaren gör skada på target
        }
 
    }
}
