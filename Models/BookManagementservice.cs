using System.Collections.Concurrent;
using BookManagement.Models.Book;

/// <summary>
/// manages actions against the book library
/// </summary>
/// <author>Brandon</author>
public class BookManagementservice
{
  /// <summary>
  /// Creates dummy data of books
  /// </summary>
  Dictionary<string, Book> BookCollection = new Dictionary<string, Book>
  {
    {"1",new Book("1","Harry Potter and the Chamber of Secrets", "J.K. Rowling","Childrens Fiction")},
    {"2", new Book("2","The Hobbit","J.R.R Tolkein", "Fantasy Fiction")}
  };


  /// <summary>
  /// Prompts user and gives options
  /// </summary>
  public void OnStart ()
  { 
    Console.WriteLine ("Welcome to the book management system. You currently have 2 books in your system. What would you like to do \n 1. Display books \n 2. Display Book by Book ID \n 3. Add New Book \n 4. Remove Book by Book ID \n 5. Exit");

    string UserResponse = Console.ReadLine();

    switch(UserResponse)
    {
      case "3": 
        AddBook();
        
        break;
    }

  }
  /// <summary>
  /// Method to add books to the collection
  /// </summary>
  public void AddBook()
  {
    Console.WriteLine ($"Please enter the book Title");
    string bookTitle = Console.ReadLine();
    Console.WriteLine($"Please enter the book's Author");
    string bookAuthor = Console.ReadLine();
    Console.WriteLine($"Please enter the book's Genre");
    string bookGenre = Console.ReadLine();
    Console.WriteLine($"Please enter a unique ID for the book");
    string bookID = Console.ReadLine(); 

    Book book = new Book(bookID, bookTitle, bookAuthor, bookGenre);
    BookCollection.Add(bookID, book);
  }
  
}
