using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> CategoriesList { get; set; } = new();
        public async Task OnGet(int skip = 0, int take = 25)
        {
            var Temp = new List<Category>();
            for (int i = 0; i < 500; i++)
            {
                Temp.Add
                    (
                        new Category(Guid.NewGuid(),
                        $"Categoria {i}",
                        i * 3.14M)
                    );
            }
            CategoriesList = Temp.Skip(skip)
                .Take(25)
                .ToList();
        }
    }
}
public record Category(
    Guid Id,
    string Title,
    decimal Price);
