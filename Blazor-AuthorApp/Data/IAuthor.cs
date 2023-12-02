namespace Blazor_AuthorApp.Data;

public interface IAuthor
{
    public List<Author> GetAuthors();
    public DateTime GetDateTime();
    public string GetVersion();
    public void SaveAuthor(Author author);
}