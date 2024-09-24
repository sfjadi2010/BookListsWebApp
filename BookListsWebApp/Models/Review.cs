namespace BookListsWebApp.Models;

public sealed class Review
{
    public Guid Id { get; set; }
    public string ReviewerName { get; set; } = default!;
    public string Content { get; set; } = default!;
    public int Rating { get; set; }
    public Guid BookId { get; set; }
    public Book Book { get; set; } = default!;
}
