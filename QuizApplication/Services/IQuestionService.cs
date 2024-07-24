using QuizApplication.Model;

namespace QuizApplication.Services
{
    public interface IQuestionService
    {

        List<Questions> GetAll();

        List<Questions> GetQuestionsByQuiz(int quizId);

        void Add(Questions question);

        void Remove(Questions question);

        List<int> GetAllQuizId();
    }
}
