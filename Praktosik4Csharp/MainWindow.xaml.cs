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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Praktosik4Csharp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EditTestButton_Click(object sender, RoutedEventArgs e)
        {
            
            AuthorizationWindow authWindow = new AuthorizationWindow();
            authWindow.ShowDialog();

            
            if (authWindow.IsAuthorized)
            {
                TestEditorWindow editorWindow = new TestEditorWindow();
                editorWindow.ShowDialog();
            }
        }

        private void TakeTestButton_Click(object sender, RoutedEventArgs e)
        {
           
            TestTakingWindow takingWindow = new TestTakingWindow();
            takingWindow.ShowDialog();
        }

    }
}
