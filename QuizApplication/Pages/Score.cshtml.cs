using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuizApplication.Pages
{
    public class ScoreModel : PageModel
    {
        public string? Score { get; set; }

        public void OnGet()
        {
            Score = TempData["Score"]?.ToString();
            TempData.Remove("Score");
        }
    }
}
