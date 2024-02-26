

namespace InMemoryDB.Entities
{
    public class Book:BaseEntity,IExample
    {
        public string Title { get; set; } = null!;
        public int PublishingYear { get; set; }

        public Author Author { get; set; }=null!;

        public void ExampleMethod()
        {
            Console.WriteLine("Hello world");
        }
    }

    public interface IExample
    {
        void ExampleMethod();
        
    }
}
