namespace humans_and_animals
{
    class Leaf : Food
    { 
        public Leaf(int level)
        {
            Level = level;
        }

        public override string ToString()
        {
            return " Det finns nu " + Level + " blad kvar.";
        }

    }
}