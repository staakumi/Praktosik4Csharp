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
using static Praktosik4Csharp.TestTakingWindow;

namespace Praktosik4Csharp
{
    /// <summary>
    /// Логика взаимодействия для TestEditorWindow.xaml
    /// </summary>
    public partial class TestEditorWindow : Window
    {
        public TestEditorWindow()
        {
            InitializeComponent();
        }
        private void SaveTestButton_Click(object sender, RoutedEventArgs e)
        {
            TestData testData = (TestData)TestDataGrid.SelectedItem;

            if (testData != null)
            {
                
                testData.Title = "Updated Title";
                testData.Option1 = "New Option 1";

               
                List<TestData> updatedTestDataList = new List<TestData>();
                foreach (TestData item in TestDataGrid.ItemsSource)
                {
                    if (item == testData)
                    {
                        updatedTestDataList.Add(testData); 
                    }
                    else
                    {
                        updatedTestDataList.Add(item); 
                    }
                }

                
                TestManager.SaveTestData(updatedTestDataList);
            }
            else
            {
                MessageBox.Show("Please select a test data item to save.");
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
    }
}
