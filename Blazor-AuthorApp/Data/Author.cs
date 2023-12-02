using System.ComponentModel.DataAnnotations;

namespace Blazor_AuthorApp.Data;

public class Author
{
    public int Id { get; set; }
    
    [Required (ErrorMessage = "Name is Required")]
    public string Name { get; set; }
    
    [Required (ErrorMessage = "State is Required")]
    public string State { get; set; }
    
    [Required (ErrorMessage = "City is Required")]
    public string City { get; set; }

    public Author()
    {
        
    }

    public Author(int id, string name, string state, string city)
    {
        Id = id;
        Name = name;
        State = state;
        City = city;
    }
}