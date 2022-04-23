namespace Homework2.API.Models
{

    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }

    public class Author: BaseEntity
    {
        public string Name { get; set; }

    }
}
