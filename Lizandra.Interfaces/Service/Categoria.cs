namespace Lizandra.Interfaces
{
    public class Categoria
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }


        public Categoria(string id, string name, int tier)
        {
            Id = id;
            Name = name;
            Tier = tier;
        }
    }
}