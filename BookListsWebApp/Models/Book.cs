using System.ComponentModel.DataAnnotations;

namespace BookListsWebApp.Models;

public sealed class Book
{
    [Key]
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string Description { get; set; }
}
