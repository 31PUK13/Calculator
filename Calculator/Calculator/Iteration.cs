using System;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow
    {
        class Iteration
        {
            public static double a;
            public static double b;

            public static string operation;

            public static bool firstOperation = true;
            public static bool newNumberPrint = false;
            public static bool firstAnswer = true;
            public static bool wordOnHistory = false;
            public static bool firstWordOnHistory = false;
            public static bool stopPrint = false;
            public static bool allowAddNumber = true;

            public static void ChangeFontSize(TextBlock input)
            {
                if (!double.TryParse(input.Text, out double d))
                {
                    input.FontSize = 28;
                }
                else if (input.Text.Length > 12)
                {
                    input.FontSize = 30;
                }
                else if(input.Text.Length <= 12)
                {
                    input.FontSize = 42;
                }
                
            }

            public static void CheckCountOfInput(TextBlock input)
            {
                int max = 16;
                if(input.Text.Contains("-"))
                {
                    max += 1;
                }
                if (input.Text.Contains("."))
                {
                    max += 1;
                }
                if (max == input.Text.Length)
                {
                    allowAddNumber = false;
                }
                else
                {
                    allowAddNumber = true;
                }
            }

            public static void CorrectInput(TextBlock input)
            {
                if(operation == "/" && input.Text == "NaN")
                {
                    stopPrint = true;
                    input.Text = "Result is undefined";
                }
                else if (input.Text == "NaN")
                {
                    stopPrint = true;
                    input.Text = "Invalid input";
                }
                else if (input.Text == "∞")
                {
                    stopPrint = true;
                    input.Text = "Сan't divide by zero";
                }
                ChangeFontSize(input);
            }


            public static void AddNumber(TextBlock input, TextBlock history, string number)
            {
                CheckCountOfInput(input);
                if (stopPrint)
                {
                    return;
                }
                if(!allowAddNumber)
                {
                    return;
                }
                if(wordOnHistory)
                {
                    ClearHistory(history);
                    newNumberPrint = false;
                    firstWordOnHistory = false;
                    wordOnHistory = false;
                }
                if(input.Text == "0" || !newNumberPrint)
                {
                    input.Text = number;
                }
                else
                {
                    input.Text += number;
                }
                ChangeFontSize(input);
                newNumberPrint = true;
            }
            public static void Point(TextBlock input, TextBlock history)
            {
                if (stopPrint)
                {
                    return;
                }
                if(input.Text.Length >= 15)
                {
                    if(!input.Text.Contains("-"))
                    {
                        return;
                    }
                    else if (input.Text.Length >= 16)
                    {
                        return;
                    }
                }
                if (wordOnHistory)
                {
                    ClearHistory(history);
                    newNumberPrint = false;
                    firstWordOnHistory = false;
                    wordOnHistory = false;
                }
                if (!newNumberPrint)
                {
                    input.Text = "0.";
                }
                if(!input.Text.Contains("."))
                {
                    input.Text +=".";
                }
                ChangeFontSize(input);
                newNumberPrint = true;
            }

            public static void ClearHistory(TextBlock history)
            {
                int position = 0;
                string help = "";
                for(int i = history.Text.Length - 2; i >= 0; i--)
                {
                    if(history.Text[i] == ' ')
                    {
                        position = i + 1;
                        break;
                    }
                }
                for(int i = 0; i<position; i++)
                {
                    help+=history.Text[i];
                }
                history.Text = help;
            }
            public static void ChangeSign(TextBlock input, TextBlock history)
            {
                if (stopPrint)
                {
                    return;
                }
                if (input.Text != "0")
                {
                    if(!newNumberPrint || wordOnHistory)
                    {
                        PrintNegative(input, history);
                        firstWordOnHistory = true;
                        wordOnHistory = true;
                    }
                    if (input.Text.Contains("-"))
                    {
                        input.Text = input.Text.Remove(0, 1);
                    }
                    else
                    {
                        input.Text = "-" + input.Text;
                    }
                }
                ChangeFontSize(input);
            }
            public static void PrintNegative(TextBlock input,TextBlock history)
            {
                if (!firstWordOnHistory)
                    history.Text += input.Text;
                int position = 0;
                history.Text += ")";
                for(int i = history.Text.Length - 1; i >= 0; i--)
                {
                    if (history.Text[i] == ' ')
                    {
                        position = i;
                        break;
                    }
                }
                string help = "";
                for (int i = 0; i < history.Text.Length; i++)
                {
                    if (position == 0 && position == i)
                    {
                        help += "negate(";
                    }
                    help += history.Text[i];
                    if (position != 0 && position == i)
                    {
                        help += "negate(";
                    }
                }
                history.Text = help;
            }
            public static void Sqrt(TextBlock input, TextBlock history)
            {
                if (stopPrint)
                {
                    return;
                }
                PrintSqrt(input, history);
                input.Text = Math.Sqrt((double.Parse(input.Text))).ToString();
                firstWordOnHistory = true;
                wordOnHistory = true;
                CorrectInput(input);
                ChangeFontSize(input);
            }

            public static void PrintSqrt(TextBlock input, TextBlock history)
            {
                if (!firstWordOnHistory)
                {
                    history.Text += input.Text;
                }
                int position = 0;
                history.Text += ")";
                for (int i = history.Text.Length - 1; i >= 0; i--)
                {
                    if (history.Text[i] == ' ')
                    {
                        position = i;
                        break;
                    }
                }
                string help = "";
                for (int i = 0; i < history.Text.Length; i++)
                {
                    if(position == 0 && position == i)
                    {
                        help += "sqrt(";
                    }
                    help += history.Text[i];
                    if (position != 0 && position == i)
                    {
                        help += "sqrt(";
                    }
                }
                history.Text = help;
            }

            public static void Reciproc(TextBlock input, TextBlock history)
            {
                if (stopPrint)
                {
                    return;
                }
                PrintReciproc(input, history);
                input.Text = (1/(double.Parse(input.Text))).ToString();
                if(Math.Abs(Math.Round(double.Parse(input.Text)) - double.Parse(input.Text)) < 1e-7)
                {
                    input.Text = Math.Round(double.Parse(input.Text)).ToString();
                }
                firstWordOnHistory = true;
                wordOnHistory = true;
                CorrectInput(input);
                ChangeFontSize(input);
            }

            public static void PrintReciproc(TextBlock input, TextBlock history)
            {
                if (!firstWordOnHistory)
                {
                    history.Text += input.Text;
                }
                int position = 0;
                history.Text += ")";
                for (int i = history.Text.Length - 1; i >= 0; i--)
                {
                    if (history.Text[i] == ' ')
                    {
                        position = i;
                        break;
                    }
                }
                string help = "";
                for (int i = 0; i < history.Text.Length; i++)
                {
                    if (position == 0 && position == i)
                    {
                        help += "reciproc(";
                    }
                    help += history.Text[i];
                    if (position != 0 && position == i)
                    {
                        help += "reciproc(";
                    }
                }
                history.Text = help;
            }

            public static void Percent(TextBlock input, TextBlock history)
            {
                if (stopPrint)
                {
                    return;
                }
                if (wordOnHistory)
                {
                    ClearHistory(history);
                }
                firstWordOnHistory = true;
                newNumberPrint = false;
                wordOnHistory = true;
                input.Text = (a * double.Parse(input.Text) / 100).ToString();
                history.Text += input.Text;
            }

            public static void DeleteOneNumber(TextBlock input)
            {
                if (stopPrint)
                {
                    return;
                }
                if (newNumberPrint)
                {
                    if (input.Text.Length == 1)
                    {
                        input.Text = "0";
                    }
                    else
                    {
                        input.Text = input.Text.Remove(input.Text.Length - 1, 1);
                    }
                }
                ChangeFontSize(input);
            }
            public static void ClearInput(TextBlock input, TextBlock history)
            {
                if (stopPrint)
                {
                    return;
                }
                if (wordOnHistory)
                {
                    ClearHistory(history);
                    newNumberPrint = false;
                    firstWordOnHistory = false;
                    wordOnHistory = false;
                }
                input.Text = "0";
                newNumberPrint = true;
                ChangeFontSize(input);
            }

            public static void ClearAll(TextBlock input, TextBlock history)
            {
                input.Text = "0";
                history.Text = "";
                a = 0;
                b = 0;
                operation = "";
                firstOperation = true;
                newNumberPrint = false;
                firstAnswer = true;
                wordOnHistory = false;
                firstWordOnHistory = false;
                stopPrint = false;
                ChangeFontSize(input);
            }


            public static void ChoseOperation(TextBlock input, TextBlock history, string symbol)
            {
                if (stopPrint)
                {
                    return;
                }
                if (input.Text[input.Text.Length - 1] == '.')
                {
                    input.Text = input.Text.Remove(input.Text.Length - 1, 1);
                }
                if (firstOperation)
                {
                    if (wordOnHistory)
                    {
                        history.Text += " " + symbol + " ";
                    }
                    else
                    {
                        history.Text = input.Text + " " + symbol + " ";
                    }
                    a = double.Parse(input.Text);
                    firstOperation = false;
                    operation = symbol;

                }
                else
                {
                    if (wordOnHistory)
                    {
                        history.Text += " " + symbol + " ";
                        b = double.Parse(input.Text);
                        Operation();
                        input.Text = a.ToString();
                        operation = symbol;
                    }
                    else if (newNumberPrint)
                    {
                        history.Text += input.Text + " " + symbol + " ";
                        b = double.Parse(input.Text);
                        Operation();
                        CorrectInput(input);
                        input.Text = a.ToString();
                        operation = symbol; 
                    }
                    else
                    {
                        operation = symbol;
                        history.Text = history.Text.Remove(history.Text.Length - 2, 2) + operation + " ";
                    }
                }
                newNumberPrint = false;
                firstAnswer = true;
                firstWordOnHistory = false;
                wordOnHistory = false;
                
            }

            static void Operation()
            {
                if(operation == "+")
                {
                    a += b;
                }
                if(operation == "-")
                {
                    a -= b;
                }
                if(operation == "*")
                {
                    a *= b;
                }
                if(operation == "/")
                {
                    a /= b;
                }
                
            }
            public static void Answer(TextBlock input, TextBlock history)
            {
                if (stopPrint)
                {
                    return;
                }
                if (history.Text == "")
                {
                    a = double.Parse(input.Text);
                }
                history.Text = "";  
                if(firstAnswer)
                {
                    b = double.Parse(input.Text);
                }
                Operation();
                input.Text = a.ToString();
                firstAnswer = false;
                newNumberPrint = false;
                firstOperation = true;
                firstWordOnHistory = false;
                wordOnHistory = false;
                CorrectInput(input);
            }
        }
    }
}
