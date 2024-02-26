

namespace InMemoryDB.Entities
{
    public class Author:BaseEntity
    {
        public string FullName { get; set; } = null!;
        public int BirthYear { get; set; }
    }
}
