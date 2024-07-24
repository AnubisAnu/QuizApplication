using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuizApplication.Model;
using QuizApplication.Services;


namespace QuizApplication.Pages
{
    public class QuestionsModel : PageModel
    {
        [BindProperty]
        public Questions? Question { get; set; }

        private IQuestionService _service { get; set; }

        public QuestionsModel(IQuestionService service)
        {
            _service = service;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Add(Question);

            return Redirect("/Quizes");
        }

        public string Message { get; set; }

        public IActionResult Remove()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                _service.Remove(Question);
            }
            catch (Exception ex)
            {
                Message = $"Error removing database";
            }

            return Redirect("/Quizes");
        }
    }
}
