using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*var lectures = new List<Lecture>
        {
            new Lecture { Id = 1, Name = "Лекция 1", Description = "Описание лекции 1" },
            new Lecture { Id = 2, Name = "Лекция 2", Description = "Описание лекции 2" },
            new Lecture { Id = 3, Name = "Лекция 3", Description = "Описание лекции 3" }
        };*/
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public List<Question> GetQuestionsFromDatabase()
        {
            List<Question> questions = new List<Question>
        {
            new Question
            {
                Id = 1,
                Text = "Какое соотношение кофе и воды рекомендуется для заваривания кофе?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 1, Text = "1 столовая ложка кофе на 4 унции воды", IsCorrect = false },
                    new Answer { Id = 2, Text = "2 столовые ложки кофе на 6 унций воды", IsCorrect = true },
                    new Answer { Id = 3, Text = "3 столовые ложки кофе на 8 унций воды", IsCorrect = false }
                }
            },
            new Question
            {
                Id = 2,
                Text = "Какой помол зерен требуется для заваривания кофе во френч-прессе?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 4, Text = "Очень мелкий", IsCorrect = false },
                    new Answer { Id = 5, Text = "Крупный", IsCorrect = true },
                    new Answer { Id = 6, Text = "Средний", IsCorrect = false }
                }
            },
            new Question
            {
                Id = 3,
                Text = "Какая температура воды является идеальной для заваривания кофе?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 7, Text = "80-85 градусов Цельсия", IsCorrect = false },
                    new Answer { Id = 8, Text = "90-96 градусов Цельсия", IsCorrect = true },
                    new Answer { Id = 9, Text = "100 градусов Цельсия", IsCorrect = false }
                }
            }
        };

            return questions;
        }

        public IActionResult Lecture1()
        {
            List<Question> questions = GetQuestionsFromDatabase();
            return View(questions);
        }

        [HttpPost]
        public IActionResult Result(List<Answer> answers)
        {
            // Обработка ответов пользователя
            // Подсчет правильных ответов и вывод результатов

            return View("Result");
        }

        public List<Question2> GetQuestions2FromDatabase()
        {
            List<Question2> questions2 = new List<Question2>
        {
            new Question2
            {
                Id2 = 1,
                Text2 = "Какой вид кофе лучше всего подходит для приготовления латте и капучино?",
                Answers2 = new List<Answer2>
                {
                    new Answer2 { Id2 = 1, Text2 = "С кислыми нотками", IsCorrect2 = false },
                    new Answer2 { Id2 = 2, Text2 = "С богатым и насыщенным вкусом и низкой кислотностью", IsCorrect2 = true },
                    new Answer2 { Id2 = 3, Text2 = "С фруктовыми оттенками", IsCorrect2 = false }
                }
            },
            new Question2
            {
                Id2 = 2,
                Text2 = "Что является важным при вспенивании молока для капучино и латте?",
                Answers2 = new List<Answer2>
                {
                    new Answer2 { Id2 = 4, Text2 = "Создание крупных пузырьков", IsCorrect2 = false },
                    new Answer2 { Id2 = 5, Text2 = "Создание мелкой и гладкой текстуры", IsCorrect2 = true },
                    new Answer2 { Id2 = 6, Text2 = "Добавление сливок", IsCorrect2 = false }
                }
            },
            new Question2
            {
                Id2 = 3,
                Text2 = "Что представляет собой латте-арт?",
                Answers2 = new List<Answer2>
                {
                    new Answer2 { Id2 = 7, Text2 = "Способ приготовления кофе", IsCorrect2 = false },
                    new Answer2 { Id2 = 8, Text2 = "Техника вспенивания молока", IsCorrect2 = false },
                    new Answer2 { Id2 = 9, Text2 = "Искусство украшения кофейного напитка", IsCorrect2 = true }
                }
            }
        };

            return questions2;
        }

        public IActionResult Lecture2()
        {
            List<Question2> questions2 = GetQuestions2FromDatabase();
            return View(questions2);
        }

        public List<Question3> GetQuestions3FromDatabase()
        {
            List<Question3> questions3 = new List<Question3>
        {
            new Question3
            {
                Id3 = 1,
                Text3 = "Что является одним из ключевых факторов успеха в кофейном бизнесе?",
                Answers3 = new List<Answer3>
                {
                    new Answer3 { Id3 = 1, Text3 = "Местоположение", IsCorrect3 = true },
                    new Answer3 { Id3 = 2, Text3 = "Размер помещения", IsCorrect3 = false },
                    new Answer3 { Id3 = 3, Text3 = "Цвет стен", IsCorrect3 = false }
                }
            },
            new Question3
            {
                Id3 = 2,
                Text3 = "Что важно для обеспечения качества продукции в кофейном бизнесе?",
                Answers3 = new List<Answer3>
                {
                    new Answer3 { Id3 = 4, Text3 = "Профессиональное оборудование", IsCorrect3 = true },
                    new Answer3 { Id3 = 5, Text3 = "Дешевые ингредиенты", IsCorrect3 = false },
                    new Answer3 { Id3 = 6, Text3 = "Мало времени на приготовление", IsCorrect3 = false }
                }
            },
            new Question3
            {
                Id3 = 3,
                Text3 = "Что следует делать для удержания клиентов в кофейном бизнесе?",
                Answers3 = new List<Answer3>
                {
                    new Answer3 { Id3 = 7, Text3 = "Обучать персонал", IsCorrect3 = true },
                    new Answer3 { Id3 = 8, Text3 = "Игнорировать обратную связь", IsCorrect3 = false },
                    new Answer3 { Id3 = 9, Text3 = "Ухаживать за клиентами только в первый месяц работы", IsCorrect3 = false }
                }
            }
        };

            return questions3;
        }

        public IActionResult Lecture3()
        {
            List<Question3> questions3 = GetQuestions3FromDatabase();
            return View(questions3);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
