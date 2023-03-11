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



namespace InputOutputApp
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
        
        // Change color of MainBorder onClick by Button ChangeColor
        private void ChangeColorButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte red = (byte)random.Next(256);
            byte green = (byte)random.Next(256);
            byte blue = (byte)random.Next(256);

            MainBorder.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
        // Reset applied changes
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            MainBorder.Background = Brushes.AliceBlue;

            BrandComboBox.SelectedIndex = 0;

            PickColor.Text = "";

            GPSCheckbox.IsChecked = CameraCheckbox.IsChecked = SeatsCheckbox.IsChecked = SoundCheckbox.IsChecked =
            EngineCheckbox.IsChecked = ChargerCheckbox.IsChecked = SuspensionCheckbox.IsChecked =
            LightsCheckbox.IsChecked = MirrosCheckbox.IsChecked = CruiseControlCheckbox.IsChecked = false;

            CountryTextBox.Text = AdressTextBox.Text = PostalCodeTextBox.Text = "";

            NoteText.Text = "";
        }
        // Change color of texbox
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Color color = (Color)ColorConverter.ConvertFromString(PickColor.Text);
                ShowingColor.Background = new SolidColorBrush(color);
                ShowingColor.Text = "";
            }
            catch (FormatException)
            {
                ShowingColor.Text = " Invalid color format ";
                ShowingColor.Background = default;
            }
        }
        // Apply changes 
        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            string CarBrand = ((ComboBoxItem)BrandComboBox.SelectedItem).Content.ToString(); 
            string CarColor = PickColor.Text;
            string FullAdress = $"Full Adress: {CountryTextBox.Text} {AdressTextBox.Text} {PostalCodeTextBox.Text}";
            string AdditonalNote = NoteText.Text;

            MessageBox.Show("Car Brand: " + CarBrand + "\n" +
                "Car Color: " +
                CarColor + "\n" +
                "Accessories are being implemented" + "\n" +
                FullAdress +"\n" +
                "Note: "+AdditonalNote
                , "Applied Values") ;
        }
    }
}
