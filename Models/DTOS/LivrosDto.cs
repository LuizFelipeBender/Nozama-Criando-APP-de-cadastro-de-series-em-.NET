namespace Nozama.Models.DTOS
{
    public class LivrosDto
    {
        public string Id { get; set; }

        public string Name { get; set; }
    
        public string Author { get; set; }

        public string Publisher { get; set; }   

        public string Genre    { get; set; }

        public long EAN13 { get; set; }

        public LivrosDto(string Id, string Name, string Author, string Publisher, string Genre, long EAN13)
            : this(Name, Author, Publisher, Genre, EAN13)
        {
         this.Id = Id;
         
        }

        public LivrosDto(string name, string author, string publisher, string genre, long eAN13)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            Genre = genre;
            EAN13 = eAN13;
        }
    }
}
