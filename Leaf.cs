namespace humans_and_animals
{
    class Leaf : Food
    { 
        public Leaf(int level)
        {
            Level = level;
        }
        //Metoden ToString(). Kallas på med ordet leaf.
        public override string ToString()
        {
            //Skriver ut hur många blad det finns kvar.
            return " Det finns nu " + Level + " blad kvar.";
        }

    }
}