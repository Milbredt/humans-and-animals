namespace humans_and_animals
{
    class Meat : Food
    { 
        public Meat(int level)
        {
            Level = level;
        }

        public override string ToString()
        {
            return " Det finns nu " + Level + " köttbitar kvar.";
        }



    }
}