namespace iabilet.domain
{
    public class Artist: Entity
    {
        public string Name { get; set; }
        public int GenreId { get; set; }
        public bool Band { get; set; }

        public override string ToString()
        {
            return "name: " + Name + ", band: " + Band;
        }
    }
}