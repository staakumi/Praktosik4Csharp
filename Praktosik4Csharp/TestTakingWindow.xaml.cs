using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Praktosik4Csharp
{
    public partial class TestTakingWindow : Window
    {
        public TestTakingWindow()
        {
            InitializeComponent();
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            Question nextQuestion = GetNextQuestion();

            if (nextQuestion != null)
            {
                DisplayQuestion(nextQuestion);
            }
            else
            {
                MessageBox.Show("No more questions available.");
            }
        }

        private void SubmitTestButton_Click(object sender, RoutedEventArgs e)
        {
            // Реализуйте логику для отправки теста
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private Question GetNextQuestion()
        {
            // Пример реализации: создаем временные тестовые данные
            return new Question
            {
                QuestionId = 1,
                Text = "What is the capital of France?",
                Options = new List<string> { "London", "Paris", "Berlin", "Madrid" },
                CorrectAnswer = "Paris"
            };
        }

        private void DisplayQuestion(Question question)
        {
            // Реализуйте отображение вопроса на экране
        }

        public enum CorrectOption
        {
            Option1,
            Option2,
            Option3
        }

        [Serializable]
        public class Question
        {
            public int QuestionId { get; set; }
            public string Text { get; set; }
            public List<string> Options { get; set; }
            public string CorrectAnswer { get; set; }
        }
    }
}


