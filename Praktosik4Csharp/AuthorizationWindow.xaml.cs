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
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public bool IsAuthorized { get; private set; }
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void AuthorizeButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (PasswordBox.Password == "password")
            {
                IsAuthorized = true;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid password. Please try again.");
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
