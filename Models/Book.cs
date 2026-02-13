namespace BookManagement.Models.Book;

/// <summary>
/// Class to hold all book-related fields.
/// </summary>
/// <author>Henry Slough</author>
public class Book
{
    public string BookId {get; set;}
    public string Title {get; set;}
    public string Author {get; set;}
    public string Genre {get; set;}

    /// <summary>
    /// Complete constructor for Book class.
    /// </summary>
    /// <param name="id">Unique identifier for each book.</param>
    /// <param name="title">The title of the given book.</param>
    /// <param name="author">The author of the given book. Author First and Last Name.</param>
    /// <param name="genre">The genre of the given book. Category.</param>
    public Book(string id, string title, string author, string genre)
    {
        BookId = id;
        Title = title;
        Author = author;
        Genre = genre;
    }
}