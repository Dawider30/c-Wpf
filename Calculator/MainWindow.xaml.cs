using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Calulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int OperationValue;

        public MainWindow()
        {
            InitializeComponent();
        }
        // Move Window
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        // Minimize Window

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        // Change Window state to maximized or normal

        private void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;

        }

        // Close application

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        // Copy value from MainItem
        private void MainItem_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(MainItem.Text);
        }

        // Copy value from SecondItem

        private void SecondItem_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(SecondItem.Text);
        }

        // Add number to MainItem

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string value = (string)button.Content;
            if (MainItem.Text == "0")
                MainItem.Text = value;
            else
                MainItem.Text += value;
        }

        // Delete number to MainItem

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainItem.Text.Length > 0)
                MainItem.Text = MainItem.Text.Remove(MainItem.Text.Length - 1);
            if (MainItem.Text.Length == 0)
                MainItem.Text = "0";
        }

        // Adding value button click

        private void AdditonButton_Click(object sender, RoutedEventArgs e)
        {
            if (SecondItem.Text == "-")
            {
                float firstValue = Convert.ToSingle(MainItem.Text);
                SecondItem.Text = firstValue.ToString();
                OperationItem.Text = " + ";
                MainItem.Text = "0";

                OperationValue = 1;
            }
            else
            {
                float firstValue = Convert.ToSingle(MainItem.Text);
                float secondValue = Convert.ToSingle(SecondItem.Text);
                 
                float result = firstValue + secondValue;

                SecondItem.Text = result.ToString();
                MainItem.Text = "0";
                OperationItem.Text = " + ";
            }
        }

        // Subtracte value button click

        private void SubtractionButton_Click(object sender, RoutedEventArgs e)
        {
            if (SecondItem.Text == "-")
            {

                float firstValue = Convert.ToSingle(MainItem.Text);
                SecondItem.Text = firstValue.ToString();
                OperationItem.Text = " - ";
                MainItem.Text = "0";

                OperationValue = 2;
            }
            else
            {
                float firstValue = Convert.ToSingle(MainItem.Text);
                float secondValue = Convert.ToSingle(SecondItem.Text);

                float result = -(firstValue - secondValue);

                if (result == 0)
                {
                    result = 0;
                }

                SecondItem.Text = result.ToString();
                MainItem.Text = "0";
                OperationItem.Text = " - ";
            }
        }

        // Multiplicate value button click

        private void MultiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            if (SecondItem.Text == "-")
            {

                float firstValue = Convert.ToSingle(MainItem.Text);
                SecondItem.Text = firstValue.ToString();
                OperationItem.Text = " × ";
                MainItem.Text = "0";

                OperationValue = 3;
            }
            else
            {
                float firstValue = Convert.ToSingle(MainItem.Text);
                float secondValue = Convert.ToSingle(SecondItem.Text);

                float result = firstValue * secondValue;

                SecondItem.Text = result.ToString();
                MainItem.Text = "0";
                OperationItem.Text = " × ";
            }
        }

        // Divide value button click

        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {                    
            if (SecondItem.Text == "-")
            {
                if (MainItem.Text == "0")
                {
                    MessageBox.Show("Don't divide by 0", "Alert");
                    return;
                }

                float firstValue = Convert.ToSingle(MainItem.Text);
                SecondItem.Text = firstValue.ToString();
                OperationItem.Text = " ÷ ";
                MainItem.Text = "0";

                OperationValue = 4;
            }
            else
            {
                if (MainItem.Text == "0")
                {
                    MessageBox.Show("Don't divide by 0", "Alert");
                    return;
                }

                float firstValue = Convert.ToSingle(MainItem.Text);
                float secondValue = Convert.ToSingle(SecondItem.Text);

                float result = firstValue / secondValue;

                SecondItem.Text = result.ToString();
                MainItem.Text = "0";
                OperationItem.Text = " ÷ ";
            }
        }

        // Make operation on two numbers

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainItem.Text == "0" || SecondItem.Text == "-")
                return;

            float firstValue = Convert.ToSingle(MainItem.Text);
            float secondValue = Convert.ToSingle(SecondItem.Text);
            float result = 0;

            switch (OperationValue)
            {
                case 1:
                    result = firstValue + secondValue;
                    break;
                case 2:
                    result = secondValue - firstValue;
                    break;
                case 3:
                    result = firstValue * secondValue;
                    break;
                case 4:
                    result = secondValue / firstValue;
                    break;
                default:
                    break;
            }

            SecondItem.Text = "-";
            MainItem.Text = result.ToString();
            OperationItem.Text = "";
        }


        // Clear all values 

        private void ClearAllButton_Click(object sender, RoutedEventArgs e)
        {
            SecondItem.Text = "-";
            OperationItem.Text = "";
            MainItem.Text = "0";
        }

        // Clear main value

        private void ClearMainValueButton_Click(object sender, RoutedEventArgs e)
        {
            MainItem.Text = "0";
        }

        // Calculates percent value

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainItem.Text == "0" || SecondItem.Text =="-")
                return;
            float firstValue = Convert.ToSingle(MainItem.Text);
            float secondValue = Convert.ToSingle(SecondItem.Text);
            
            float result = (secondValue * firstValue)/100;

            MainItem.Text = result.ToString();

        }

        // Adds coma to the value

        private void AddComaButton_Click(object sender, RoutedEventArgs e)
        {
            decimal decimalValue;
            if (decimal.TryParse(MainItem.Text, out decimalValue))
            {
                MainItem.Text = decimalValue.ToString("N");
            }
        }

        // Changes value to Negative Or Positive

        private void NegativeOrPositiveButton_Click(object sender, RoutedEventArgs e)
        {
            float AbsoluteValue = Convert.ToSingle(MainItem.Text);

            AbsoluteValue = -AbsoluteValue;

            MainItem.Text = AbsoluteValue.ToString();
        }

        // Inverse value

        private void InverseValueButton_Click(object sender, RoutedEventArgs e)
        {
            if(MainItem.Text == "0")
            {
                MessageBox.Show("Don't divide by 0", "Alert");
                return;
            }


            float InverseValue = Convert.ToSingle(MainItem.Text);

            InverseValue = 1/InverseValue;

            MainItem.Text = InverseValue.ToString();
        }

        // Calculate value to power 2

        private void PowerTwoButton_Click(object sender, RoutedEventArgs e)
        {
            float PowerTwo = Convert.ToSingle(MainItem.Text);

            PowerTwo = PowerTwo*PowerTwo;

            MainItem.Text = PowerTwo.ToString();
        }

        // Calculates square root of the value

        private void SquareRootButton_Click(object sender, RoutedEventArgs e)
        {
            float PowerTwo = Convert.ToSingle(MainItem.Text);

            if(PowerTwo<0)
            {
                MessageBox.Show("Number cannot be negative", "Alert");
                return;
            }

            PowerTwo = (float)Math.Sqrt(PowerTwo) ;

            MainItem.Text = PowerTwo.ToString();
        }
    }      
}
