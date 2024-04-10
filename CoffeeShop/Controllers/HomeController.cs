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
            new Lecture { Id = 1, Name = "������ 1", Description = "�������� ������ 1" },
            new Lecture { Id = 2, Name = "������ 2", Description = "�������� ������ 2" },
            new Lecture { Id = 3, Name = "������ 3", Description = "�������� ������ 3" }
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
                Text = "����� ����������� ���� � ���� ������������� ��� ����������� ����?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 1, Text = "1 �������� ����� ���� �� 4 ����� ����", IsCorrect = false },
                    new Answer { Id = 2, Text = "2 �������� ����� ���� �� 6 ����� ����", IsCorrect = true },
                    new Answer { Id = 3, Text = "3 �������� ����� ���� �� 8 ����� ����", IsCorrect = false }
                }
            },
            new Question
            {
                Id = 2,
                Text = "����� ����� ����� ��������� ��� ����������� ���� �� �����-������?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 4, Text = "����� ������", IsCorrect = false },
                    new Answer { Id = 5, Text = "�������", IsCorrect = true },
                    new Answer { Id = 6, Text = "�������", IsCorrect = false }
                }
            },
            new Question
            {
                Id = 3,
                Text = "����� ����������� ���� �������� ��������� ��� ����������� ����?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 7, Text = "80-85 �������� �������", IsCorrect = false },
                    new Answer { Id = 8, Text = "90-96 �������� �������", IsCorrect = true },
                    new Answer { Id = 9, Text = "100 �������� �������", IsCorrect = false }
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
            // ��������� ������� ������������
            // ������� ���������� ������� � ����� �����������

            return View("Result");
        }

        public List<Question2> GetQuestions2FromDatabase()
        {
            List<Question2> questions2 = new List<Question2>
        {
            new Question2
            {
                Id2 = 1,
                Text2 = "����� ��� ���� ����� ����� �������� ��� ������������� ����� � ��������?",
                Answers2 = new List<Answer2>
                {
                    new Answer2 { Id2 = 1, Text2 = "� ������� �������", IsCorrect2 = false },
                    new Answer2 { Id2 = 2, Text2 = "� ������� � ���������� ������ � ������ ������������", IsCorrect2 = true },
                    new Answer2 { Id2 = 3, Text2 = "� ���������� ���������", IsCorrect2 = false }
                }
            },
            new Question2
            {
                Id2 = 2,
                Text2 = "��� �������� ������ ��� ����������� ������ ��� �������� � �����?",
                Answers2 = new List<Answer2>
                {
                    new Answer2 { Id2 = 4, Text2 = "�������� ������� ���������", IsCorrect2 = false },
                    new Answer2 { Id2 = 5, Text2 = "�������� ������ � ������� ��������", IsCorrect2 = true },
                    new Answer2 { Id2 = 6, Text2 = "���������� ������", IsCorrect2 = false }
                }
            },
            new Question2
            {
                Id2 = 3,
                Text2 = "��� ������������ ����� �����-���?",
                Answers2 = new List<Answer2>
                {
                    new Answer2 { Id2 = 7, Text2 = "������ ������������� ����", IsCorrect2 = false },
                    new Answer2 { Id2 = 8, Text2 = "������� ����������� ������", IsCorrect2 = false },
                    new Answer2 { Id2 = 9, Text2 = "��������� ��������� ��������� �������", IsCorrect2 = true }
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
                Text3 = "��� �������� ����� �� �������� �������� ������ � �������� �������?",
                Answers3 = new List<Answer3>
                {
                    new Answer3 { Id3 = 1, Text3 = "��������������", IsCorrect3 = true },
                    new Answer3 { Id3 = 2, Text3 = "������ ���������", IsCorrect3 = false },
                    new Answer3 { Id3 = 3, Text3 = "���� ����", IsCorrect3 = false }
                }
            },
            new Question3
            {
                Id3 = 2,
                Text3 = "��� ����� ��� ����������� �������� ��������� � �������� �������?",
                Answers3 = new List<Answer3>
                {
                    new Answer3 { Id3 = 4, Text3 = "���������������� ������������", IsCorrect3 = true },
                    new Answer3 { Id3 = 5, Text3 = "������� �����������", IsCorrect3 = false },
                    new Answer3 { Id3 = 6, Text3 = "���� ������� �� �������������", IsCorrect3 = false }
                }
            },
            new Question3
            {
                Id3 = 3,
                Text3 = "��� ������� ������ ��� ��������� �������� � �������� �������?",
                Answers3 = new List<Answer3>
                {
                    new Answer3 { Id3 = 7, Text3 = "������� ��������", IsCorrect3 = true },
                    new Answer3 { Id3 = 8, Text3 = "������������ �������� �����", IsCorrect3 = false },
                    new Answer3 { Id3 = 9, Text3 = "��������� �� ��������� ������ � ������ ����� ������", IsCorrect3 = false }
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
