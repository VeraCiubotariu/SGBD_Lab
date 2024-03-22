namespace iabilet.domain
{
    public class Genre: Entity
    {
        public string Name { get; set; }
        public int Popularity { get; set; }

        public override string ToString()
        {
            return "name: " + Name + ", popularity: " + Popularity;
        }
    }
}