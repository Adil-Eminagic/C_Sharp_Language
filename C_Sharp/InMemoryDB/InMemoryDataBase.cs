using InMemoryDB.Entities;

namespace InMemoryDB
{
    public class InMemoryDataBase
    {
        public List<Author> Authors { get; set; } = new List<Author>();
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Gender> Genders { get; set; } = new List<Gender>();

        public InMemoryDataBase()
        {
            Genders.Add(new Gender() { Id = 1, Value = "Male" });
            Genders.Add(new Gender() { Id = 2, Value = "Female" });

            Authors.Add(new Author() { Id = 1, FullName = "William Shakespeare", BirthYear = 1564, });
            Authors.Add(new Author() { Id = 2, FullName = "Oscar Wilde", BirthYear = 1854, });
            Authors.Add(new Author() { Id = 3, FullName = "Voltaire", BirthYear = 1694 });

            Books.Add(new Book() { Id = 1, Title = "Hamlet", PublishingYear = 1590, Author = Authors[0] });
            Books.Add(new Book() { Id = 2, Title = "Romeo and Juliet", PublishingYear = 1585, Author = Authors[0] });



        }
    }
}
