namespace Padeanu_Andreea_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<book>? Books { get; set; }
    }
}
