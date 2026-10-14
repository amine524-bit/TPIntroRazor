using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TPIntroRazor.Pages
{
    public class IndexModel : PageModel
    {
        public string MessageAccueil { get; set; } = string.Empty;
        public List<string> Modules { get; set; } = new();

        public void OnGet()
        {
            MessageAccueil = "Bienvenue dans le TP Razor Pages !";
            Modules = new List<string>
            {
                "Structure d'un projet ASP.NET Core",
                "Syntaxe Razor (@)",
                "Code-Behind et PageModel",
                "Formulaires et [BindProperty]"
            };
        }
    }
}