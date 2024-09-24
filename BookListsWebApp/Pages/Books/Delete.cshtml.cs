using BookListsWebApp.Data;
using BookListsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListsWebApp.Pages.Books;

public class DeleteModel : PageModel
{
    private readonly BooksDbContext _context;

    public DeleteModel(BooksDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Book Book { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(Guid? id)
    {
        if (id is null)
        {
            return RedirectToPage("./Index");
        }

        var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);

        if (book is not null)
        {
            Book = book;
            return Page();
        }

        return RedirectToPage("./Index");
    }

    public async Task<IActionResult> OnPostAsync(Guid? id)
    {
        if (id is null)
        {
            return RedirectToPage("./Index");
        }

        var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);

        if (book is not null)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
