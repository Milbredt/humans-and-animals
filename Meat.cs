namespace humans_and_animals
{
    class Meat : Food
    { 
        public Meat(int level)
        {
            Level = level;
        }
        //Metoden ToString(). Kallas på med ordet meat.
        public override string ToString()
        {
            //Skriver ut hur många köttbitar det finns kvar.
            return " Det finns nu " + Level + " köttbitar kvar.";
        }



    }
}