namespace iabilet.domain
{
    public class Entity
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return "id: " + Id;
        }
    }
}