using BookListsWebApp.Data;
using BookListsWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListsWebApp.Pages.Books;

public class IndexModel : PageModel
{
    private readonly BooksDbContext _context;

    public IndexModel(BooksDbContext context)
    {
        _context = context;
    }

    public IList<Book> Books { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Books = await _context.Books.ToListAsync();
    }
}
