using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RockPaperScissors
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

        // Start Button 

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {            
            Overlay.Visibility = Visibility.Collapsed;
            ContentPanel.Visibility = Visibility.Visible;
        }
        private Border _selectedImageBorder = null;

        // Clicking on Item to chose

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image selectedImage = sender as Image;

            if (_selectedImageBorder != null)
            {
                _selectedImageBorder.BorderThickness = new Thickness(0);
                _selectedImageBorder.BorderBrush = null;
            }

            if (selectedImage == Image1)
            {
                _selectedImageBorder = ImageBorder1;
                ChosedTextBlock.Text = "You chose paper";
                BeginButton.Visibility = default;
            }
            else if (selectedImage == Image2)
            {
                _selectedImageBorder = ImageBorder2;
                ChosedTextBlock.Text = "You chose rock";
                BeginButton.Visibility = default;
            }
            else if (selectedImage == Image3)
            {
                _selectedImageBorder = ImageBorder3;
                ChosedTextBlock.Text = "You chose scissors";
                BeginButton.Visibility = default;
            }
          
        }

        // Begin Button

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            int randomNumber = GenerateRandomNumber();
            string imageSource = "";

            if (randomNumber == 1)
            {
                imageSource = "Images/paper.jpg";
                switch (ChosedTextBlock.Text)
                {
                    case "You chose paper":
                        Result.Text = "Draw";
                        break;
                    case "You chose rock":
                        Result.Text = "Bot wins";
                        break;
                    case "You chose scissors":
                        Result.Text = "Player wins";
                        break;
                    default:
                        break;
                }

            }
            else if (randomNumber == 2)
            {
                imageSource = "Images/rock.jpg";
                switch (ChosedTextBlock.Text)
                {
                    case "You chose paper":
                        Result.Text = "Player wins";
                        break;
                    case "You chose rock":
                        Result.Text = "Draw";
                        break;
                    case "You chose scissors":
                        Result.Text = "Bot wins";
                        break;
                    default:
                        break;
                }
            }
            else if (randomNumber == 3) 
            { 
                imageSource = "Images/scissors.jpg";
                switch (ChosedTextBlock.Text)
                {
                    case "You chose paper":
                        Result.Text = "Bot wins";
                        break;
                    case "You chose rock":
                        Result.Text = "Player wins";
                        break;
                    case "You chose scissors":
                        Result.Text = "Draw";
                        break;
                    default:
                        break;
                }
            }               

            ResultImage.Source = new BitmapImage(new Uri(imageSource, UriKind.Relative));
            ResultImage.Visibility = Visibility.Visible;

            RestartButton.Visibility = Visibility.Visible;
        }

        // Generate random Number

        private int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        // Restart Button

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            Overlay.Visibility = Visibility.Visible;
            ContentPanel.Visibility = Visibility.Collapsed;

            ChosedTextBlock.Text = "";
            BeginButton.Visibility = Visibility.Hidden;
            ResultImage.Visibility = Visibility.Hidden;
            Result.Text = "";
            RestartButton.Visibility = Visibility.Hidden;           
        }
    }
}
