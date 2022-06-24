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

namespace Calculator
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

        private void NumberClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Iteration.AddNumber(Input, History, button.Content.ToString());
        }
        private void ChangeSignClick(object sender, RoutedEventArgs e)
        {
            Iteration.ChangeSign(Input, History);
        }
        private void PointClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Iteration.Point(Input, History);
        }
        private void DeleteOneNumberClick(object sender, RoutedEventArgs e)
        {
            Iteration.DeleteOneNumber(Input);
        }
        private void ClearInputClick(object sender, RoutedEventArgs e)
        {
            Iteration.ClearInput(Input, History);
        }
        private void ChoseOperationsClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Iteration.ChoseOperation(Input, History, button.Content.ToString());
        }
        private void AnswerClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Iteration.Answer(Input, History);
        }

        private void SqrtClick(object sender, RoutedEventArgs e)
        {
            Iteration.Sqrt(Input, History);
        }

        private void ReciprocClick(object sender, RoutedEventArgs e)
        {
            Iteration.Reciproc(Input, History);
        }
        private void PercentClick(object sender, RoutedEventArgs e)
        {
            Iteration.Percent(Input, History);
        }
        
        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            Iteration.ClearAll(Input, History);
        }
    }
}
