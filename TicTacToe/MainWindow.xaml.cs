using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Declaration of value

        private bool CheckWchichTurn = true;
        private string imageSource = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Button click action

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button Btn = (Button)sender;
            string BtnName = Btn.Name;


            // Add Content to Button

            if (CheckWchichTurn)
            {
                Btn.Content = "X";
            }
            else
            {
                Btn.Content = "O";
            }

            // Add image to the place which was clicked

            switch (BtnName)
            {
                case "Button1":
                    HandleButtonClick(Image1, CheckWchichTurn);
                    break;

                case "Button2":
                    HandleButtonClick(Image2, CheckWchichTurn);
                    break;

                case "Button3":
                    HandleButtonClick(Image3, CheckWchichTurn);
                    break;

                case "Button4":
                    HandleButtonClick(Image4, CheckWchichTurn);
                    break;

                case "Button5":
                    HandleButtonClick(Image5, CheckWchichTurn);
                    break;

                case "Button6":
                    HandleButtonClick(Image6, CheckWchichTurn);
                    break;

                case "Button7":
                    HandleButtonClick(Image7, CheckWchichTurn);
                    break;

                case "Button8":
                    HandleButtonClick(Image8, CheckWchichTurn);
                    break;

                case "Button9":
                    HandleButtonClick(Image9, CheckWchichTurn);
                    break;

            }
            
            // Check for win

            CheckForWin();

        }

        // Add image to the place that was clicked

        private void HandleButtonClick(Image image, bool checkWhichTurn)
        {
            image.Visibility = Visibility.Visible;

            // Change Image to O on O's turn

            if (!checkWhichTurn)
            {
                imageSource = "Images/IconO.png";
                image.Source = new BitmapImage(new Uri(imageSource, UriKind.Relative));
            }
                     
            CheckWchichTurn = !checkWhichTurn;

        }

        // Check for win

        private void CheckForWin()
        {
            // Check for win in rows

                // For X

                if (Button1.Content == Button2.Content && Button2.Content == Button3.Content && Button1.Content.ToString() == "X")
                {   
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image1, Image2, Image3 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;
                    
                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button4, Button5, Button6, Button7, Button8, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                else if (Button4.Content == Button5.Content && Button5.Content == Button6.Content && Button4.Content.ToString() == "X")
                {
                    // Change Color of winned combination to red    

                    var imagesToChange = new[] { Image4, Image5, Image6 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button2, Button3, Button7, Button8, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                else if (Button7.Content == Button8.Content && Button8.Content == Button9.Content && Button7.Content.ToString() == "X")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image7, Image8, Image9 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button2, Button3, Button4, Button5, Button6 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                // For O

                else if (Button1.Content == Button2.Content && Button2.Content == Button3.Content && Button1.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image1, Image2, Image3 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button4, Button5, Button6, Button7, Button8, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }
         
                else if (Button4.Content == Button5.Content && Button5.Content == Button6.Content && Button4.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image4, Image5, Image6 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button2, Button3, Button7, Button8, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }
           
                else if (Button7.Content == Button8.Content && Button8.Content == Button9.Content && Button7.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image7, Image8, Image9 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    Button1.Visibility = Visibility.Hidden;
                    Button2.Visibility = Visibility.Hidden;
                    Button3.Visibility = Visibility.Hidden;
                    Button4.Visibility = Visibility.Hidden;
                    Button5.Visibility = Visibility.Hidden;
                    Button6.Visibility = Visibility.Hidden;

                    var buttonsToHide = new List<Button> { Button1, Button2, Button3, Button4, Button5, Button6 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

            // Check for win in columns

                // For X

                else if (Button1.Content == Button4.Content && Button4.Content == Button7.Content && Button1.Content.ToString() == "X")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image1, Image4, Image7 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    Button2.Visibility = Visibility.Hidden;
                    Button3.Visibility = Visibility.Hidden;
                    Button5.Visibility = Visibility.Hidden;
                    Button6.Visibility = Visibility.Hidden;
                    Button8.Visibility = Visibility.Hidden;
                    Button9.Visibility = Visibility.Hidden;

                    var buttonsToHide = new List<Button> { Button2, Button3, Button5, Button6, Button8, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                else if (Button2.Content == Button5.Content && Button5.Content == Button8.Content && Button2.Content.ToString() == "X")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image2, Image5, Image8 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button3, Button4, Button6, Button7, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                else if (Button3.Content == Button6.Content && Button6.Content == Button9.Content && Button3.Content.ToString() == "X")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image3, Image6, Image9 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button2, Button4, Button5, Button7, Button8 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                // For O

                else if (Button1.Content == Button4.Content && Button4.Content == Button7.Content && Button1.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image1, Image4, Image7 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button2, Button3, Button5, Button6, Button8, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;
                }

                else if (Button2.Content == Button5.Content && Button5.Content == Button8.Content && Button2.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image2, Image5, Image8 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button3, Button4, Button6, Button7, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                else if (Button3.Content == Button6.Content && Button6.Content == Button9.Content && Button3.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image3, Image6, Image9 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button2, Button4, Button5, Button7, Button8 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

            // Check for win in diagonals

                // For X

                else if (Button1.Content == Button5.Content && Button5.Content == Button9.Content && Button1.Content.ToString() == "X")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image1, Image5, Image9 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button2, Button3, Button4, Button6, Button7, Button8 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                else if (Button3.Content == Button5.Content && Button5.Content == Button7.Content && Button3.Content.ToString() == "X")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image3, Image5, Image7 };

                    foreach (var image in imagesToChange)
                        image.Source = new BitmapImage(new Uri("Images/RedIconX.png", UriKind.Relative));

                    // Result of the game

                    Winner.Text = "X's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new List<Button> { Button1, Button2, Button4, Button6, Button8, Button9 };

                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

            // For O

            else if (Button1.Content == Button5.Content && Button5.Content == Button9.Content && Button1.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var imagesToChange = new[] { Image1, Image5, Image9 };

                    foreach (var image in imagesToChange)                    
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));
                    
                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new[] { Button2, Button3, Button4, Button6, Button7, Button8 };
                    
                    foreach (var button in buttonsToHide)
                        button.Visibility = Visibility.Hidden;

                }

                else if (Button3.Content == Button5.Content && Button5.Content == Button7.Content && Button3.Content.ToString() == "O")
                {
                    // Change Color of winned combination to red

                    var winningCombination = new[] { Image3, Image5, Image7 };

                    foreach (var image in winningCombination)                    
                        image.Source = new BitmapImage(new Uri("Images/RedIconO.png", UriKind.Relative));
                    
                    // Result of the game

                    Winner.Text = "O's Wins!";

                    // Restart button made visible

                    RestartButton.Visibility = Visibility.Visible;

                    // Prevent other buttons from clicking

                    var buttonsToHide = new[] { Button1, Button2, Button4, Button6, Button8, Button9 };

                    foreach (var button in buttonsToHide)                    
                        button.Visibility = Visibility.Hidden;
                    
                }

            // Check for draw

            else if (Button1.Content.ToString() != "" && Button2.Content.ToString() != "" && Button3.Content.ToString() != "" &&
            Button4.Content.ToString() != "" && Button5.Content.ToString() != "" && Button6.Content.ToString() != "" &&
            Button7.Content.ToString() != "" && Button8.Content.ToString() != "" && Button9.Content.ToString() != "")
            {
                // Result of the game

                Winner.Text = "Draw!";

                // Restart button made visible

                RestartButton.Visibility = Visibility.Visible;
            }
        }

        // Restart Button Click

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {   
            // Hide Result of the game

            Winner.Text = "";

            // Restart button made invisible

            RestartButton.Visibility = Visibility.Hidden;

            // Game Starts from X

            CheckWchichTurn = true;

            // Making buttons visible and clearing their content

            var ButtonSources = new[] { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9 };
            foreach (var button in ButtonSources)
            {
                button.Visibility = Visibility.Visible;
                button.Content = "";
            }

            // Making images invisible 

            var ImageSourcesInvisible = new[] { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };

            foreach (var image in ImageSourcesInvisible)
            image.Visibility = Visibility.Hidden;

            // Changing images to deafult

            var ImageSourcesDeafult = new[] { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };

            foreach (var image in ImageSourcesDeafult)           
                image.Source = new BitmapImage(new Uri("Images/IconX.png", UriKind.Relative));            
        }
    }
}
