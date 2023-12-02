namespace Blazor_AuthorApp.Data;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public string City { get; set; }

    public Author(int id, string name, string state, string city)
    {
        Id = id;
        Name = name;
        State = state;
        City = city;
    }
}