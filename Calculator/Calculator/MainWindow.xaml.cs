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
        private void Button_TouchEnter(object sender, TouchEventArgs e)
        {
            kostili = true;
        }
        public bool kostili = false;
        private void NumberClick(object sender, RoutedEventArgs e)
        {
            if(kostili)
            {
                return;
            }
            kostili = false;
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

        private void HotKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                Iteration.ClearInput(Input, History);
            }
            if (e.Key == Key.Back)
            {
                Iteration.DeleteOneNumber(Input);
            }
            if (e.Key == Key.Enter)
            {
                Iteration.Answer(Input, History);
            }
        }

        private void KeyTextInput(object sender, TextCompositionEventArgs e)
        {
            if(int.TryParse(e.Text, out int n))
            {
                Iteration.AddNumber(Input, History, e.Text);
            }
            if(e.Text == "*" || e.Text == "+" || e.Text == "-" || e.Text == "/")
            {
                Iteration.ChoseOperation(Input, History, e.Text);
            }
            if (e.Text == "." || e.Text == ",")
            {
                Iteration.Point(Input, History);
            }
            if (e.Text == "%")
            {
                Iteration.Percent(Input, History);
            }
            if (e.Text == "@")
            {
                Iteration.Sqrt(Input, History);
            }
            if (e.Text == "=")
            {
                Iteration.Answer(Input, History);
            }
            if (e.Text == "r")
            {
                Iteration.Reciproc(Input, History);
            }
        }
        private void MemoryClearClick(object sender, RoutedEventArgs e)
        {
            Iteration.MemoryClear(Memory);
        }
        private void MemoryReadClick(object sender, RoutedEventArgs e)
        {
            Iteration.MemoryRead(Input, History);
        }
        private void MemorySaveClick(object sender, RoutedEventArgs e)
        {
            Iteration.MemorySave(Input,Memory);
        }
        private void MemoryPlusClick(object sender, RoutedEventArgs e)
        {
            Iteration.MemoryPlus(Input, Memory);
        }
        private void MemoryMinusClick(object sender, RoutedEventArgs e)
        {
            Iteration.MemoryMinus(Input, Memory);
        }

        
    }
}
