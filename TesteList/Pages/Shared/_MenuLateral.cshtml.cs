
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;


namespace Web.Pages.Shared
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class _MenuLateralModel : PageModel
    {
        public List<MenuItem> MenuItems { get; set; }

        public void OnGet()
        {
            string pagesPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "..", "Pages");
            var razorFiles = Directory.GetFiles(pagesPath, "*.cshtml", SearchOption.TopDirectoryOnly);

            MenuItems = razorFiles
                .Where(file => !Path.GetFileName(file).StartsWith("_"))
                .Select(file =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    return new MenuItem { Name = fileName, Url = $"/{fileName}" };
                })
                .ToList();
        }
    }
}
