namespace Blazor_AuthorApp.Data;

public class AuthorService: IAuthor
{
    public DateTime _currentDate { get; set; }
    public List<Author> _authors { get; set; }

    public AuthorService()
    {
        _currentDate = DateTime.Now;
        _authors = new List<Author>();
        _authors.Add(new Author(1, "Author-1", "Up", "Noida"));
        _authors.Add(new Author(2, "Author-2", "MP", "Bhopal"));
        _authors.Add(new Author(3, "Author-3", "MP", "Beena"));
        _authors.Add(new Author(4, "Author-4", "", ""));

    }
    
    public List<Author> GetAuthors()
    {
        return _authors;
    }

    public DateTime GetDateTime()
    {
        return _currentDate;
    }

    public string GetVersion()
    {
        return "v1";
    }

    public void SaveAuthor(Author author)
    {
        _authors.Add(author);
    }
}