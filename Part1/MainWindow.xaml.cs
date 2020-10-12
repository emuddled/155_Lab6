/// Lab No. 6		Exercise Part 1
/// File Name: Calculator
/// @author: Evan Sinclair
/// Date:  Oct 6, 2020
///
/// Problem Statement:Create a simple GUI that accepts a left hand value and a right hand value. Use a ListBox to
/// have the user choose (+, -, *, /, %). Use try-catch blocks to handle bad input.  Display a MessageBox notifying
/// the user of the error.  Have a button that calculates the results.
/// 
/// 
/// Overall Plan:.
/// 1)Create 3 Textboxes for 2 inputs and an output
/// 2)Create a ListBox and populate with operators
/// 3)Create a button to execute
/// 4)Create a try catch block within the button to catch DivideByZeroException
/// 5)create a switch statement to choose which operator will be used on the 2 input text boxes

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

namespace Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                int operation = OperationListBox.SelectedIndex;
                decimal left = Convert.ToDecimal(LeftHandBox.Text);
                decimal right = Convert.ToDecimal(RightHandBox.Text);
                decimal result = 0;

                switch (operation)
                {
                    case 0:
                        {
                            result = left + right;
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case 1:
                        {
                            result = left - right;
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case 2:
                        {
                            result = left * right;
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case 3:
                        {
                            result = left / right;
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    case 4:
                        {
                            result = left % right;
                            ResultTextBox.Text = result.ToString();
                            break;
                        }
                    default:
                        {
                            result = 0;
                            MessageBox.Show("No operator selected");
                            break;
                        }

                }


            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Error: Cannot divide by 0");
            }
        }
    }

}
