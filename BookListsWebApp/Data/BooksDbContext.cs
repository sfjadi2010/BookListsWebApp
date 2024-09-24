using BookListsWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookListsWebApp.Data;

public class BooksDbContext : IdentityDbContext<User>
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var admin = new IdentityRole("admin");
        admin.NormalizedName = "ADMIN";

        var reviewer = new IdentityRole("reviewer");
        reviewer.NormalizedName = "REVIEWER";

        var reader = new IdentityRole("reader");
        reader.NormalizedName = "READER";

        builder.Entity<IdentityRole>().HasData(admin, reviewer, reader);
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Review> Reviews { get; set; }
}
