using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet()
        {
            for (int i = 0; i < 50; i++)
            {
                Categories.Add
                    (
                        new Category(Guid.NewGuid(),
                        $"Categoria {i}",
                        i * 3.14M)
                    );
            }
        }
    }
}
public record Category(
    Guid Id,
    string Title,
    decimal Price);
