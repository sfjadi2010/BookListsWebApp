using BookListsWebApp.Data;
using BookListsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListsWebApp.Pages.Books;

public class CreateModel : PageModel
{
    private readonly BooksDbContext _context;

    public CreateModel(BooksDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Book Book { get; set; } = default!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _context.Books.Add(Book);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
