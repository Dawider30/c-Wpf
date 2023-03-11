using System;
using System.Windows;
using System.Windows.Controls;


namespace Zadanie2doszkoly
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

        // Variables inicialization

        int hajsJanka = 200; int wartoscZakladuJanka; int obstawionyChartJanka;
        int hajsBartka = 200; int wartoscZakladuBartka; int obstawionyChartBartka;
        int hajsArka = 200; int wartoscZakladuArka; int obstawionyChartArka;

        int licznik = 0;

        // Increse on click

        private void increaseButton_Click(object sender, RoutedEventArgs e)
        {
            int currentValue = int.Parse(textBox1.Text);
            textBox1.Text = (currentValue + 1).ToString();
        }

        // Decrese on click

        private void DecreaseButton_Click(object sender, RoutedEventArgs e)
        {
            int currentValue = int.Parse(textBox1.Text);
            if (currentValue > 0)
            {
                textBox1.Text = (currentValue - 1).ToString();
            }
        }

        // Increse on click

        private void increaseButton_Click_1(object sender, RoutedEventArgs e)
        {
            int currentValue = int.Parse(textBox2.Text);
            textBox2.Text = (currentValue + 1).ToString();
        }

        // Decrese on click

        private void decreaseButton_Click_1(object sender, RoutedEventArgs e)
        {
            int currentValue = int.Parse(textBox2.Text);
            if (currentValue > 0)
            {
                textBox2.Text = (currentValue - 1).ToString();
            }
        }

        // On changing textBox1

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int result))
            {
                MessageBox.Show("Podaj liczbe");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                return;
            }

            int currentValue = int.Parse(textBox1.Text);

            if (currentValue < 5)
                textBox1.Text = "5";

            else if (currentValue > 15)
                textBox1.Text = "15";
        }

        // On changing textBox2

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int result))
            {        
                MessageBox.Show("Podaj liczbe");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);

                return;
            }
                int currentValue = int.Parse(textBox2.Text);

            if(currentValue <1)            
                textBox2.Text = "1"; 
            
            else if(currentValue > 4)           
                textBox2.Text = "4";           
        }

        // Radio button click for Janek

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Gracz.Text = "Janek";
        }

        // Radio button click for Bartek

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Gracz.Text = "Bartek";
        }

        // Radio button click for Arek

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            Gracz.Text = "Arek";
        }

        // On clicking button Stawia

        private void obstaw_Click(object sender, RoutedEventArgs e)
        {
            int wartoscZakladu = int.Parse(textBox1.Text);
            int obstawionyChart = int.Parse(textBox2.Text);

            if(Gracz.Text == "Janek")
            {
                wartoscZakladuJanka = wartoscZakladu;
                obstawionyChartJanka = obstawionyChart;
                Janek.Text = $"Janek stawia {wartoscZakladu} na charta numer {obstawionyChart}";
            }
            else if(Gracz.Text == "Bartek")
            {
                wartoscZakladuBartka = wartoscZakladu;
                obstawionyChartBartka = obstawionyChart;
                Bartek.Text = $"Bartek stawia {wartoscZakladu} na charta numer {obstawionyChart}";
            }
            else if(Gracz.Text == "Arek")
            {
                wartoscZakladuArka = wartoscZakladu;
                obstawionyChartArka = obstawionyChart;
                Arek.Text = $"Arek stawia {wartoscZakladu} na charta numer {obstawionyChart}";
            }
        }

        // On clicking main Button

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            licznik++;
            if (licznik >= 10)
            {
                koniecGry();
            }

            Random random = new Random();
            int chart1 = random.Next(1, 101);
            int chart2 = random.Next(1, 101);
            int chart3 = random.Next(1, 101);
            int chart4 = random.Next(1, 101);

            // Check who won

            int wygrany =1;

            if(chart1> chart2 && chart1 > chart3 && chart1 > chart4)           
                wygrany = 1;
            
            else if(chart2 > chart1 && chart2 > chart3 && chart2 > chart4)           
                wygrany = 2;
            
            else if(chart3 > chart1 && chart3 > chart2 && chart3 > chart4)
                wygrany = 3;

            else if(chart4 > chart1 && chart4 > chart2 && chart4 > chart3)
                wygrany = 4;

            // Do on winning

            if(wygrany == obstawionyChartJanka)
            {
                wartoscZakladuJanka = wartoscZakladuJanka* 2;
                hajsJanka += wartoscZakladuJanka;
                pieniadzJanka.Content = $"Janek ma {hajsJanka} zł ";
                wartoscZakladuJanka = 0;
                Janek.Text = "Janek nie zawarł zakładu";

                hajsBartka = hajsBartka - wartoscZakladuBartka;
                pieniadzBartka.Content = $"Bartek ma {hajsBartka} zł ";

                hajsArka = hajsArka - wartoscZakladuArka;
                pieniadzArka.Content = $"Arek ma {hajsArka} zł ";

                wartoscZakladuBartka = 0;
                Bartek.Text = "Bartek nie zawarł zakładu";

                wartoscZakladuArka = 0;
                Arek.Text = "Arek nie zawarł zakładu";              
            }

            else if(wygrany == obstawionyChartBartka)
            {
                wartoscZakladuBartka = wartoscZakladuBartka * 2;
                hajsBartka += wartoscZakladuBartka;
                pieniadzBartka.Content = $"Bartek ma {hajsBartka} zł ";
                wartoscZakladuBartka = 0;
                Bartek.Text = "Bartek nie zawarł zakładu";

                hajsJanka = hajsJanka - wartoscZakladuJanka;
                pieniadzJanka.Content = $"Janek ma {hajsJanka} zł ";

                hajsArka = hajsArka - wartoscZakladuArka;
                pieniadzArka.Content = $"Arek ma {hajsArka} zł ";

                wartoscZakladuJanka = 0;
                Janek.Text = "Janek nie zawarł zakładu";

                wartoscZakladuArka = 0;
                Arek.Text = "Arek nie zawarł zakładu";              
            }

            else if (wygrany == obstawionyChartArka)
            {
                wartoscZakladuArka = wartoscZakladuArka * 2;
                hajsArka += wartoscZakladuArka;
                pieniadzArka.Content = $"Arek ma {hajsArka} zł ";
                wartoscZakladuArka = 0;
                Arek.Text = "Arek nie zawarł zakładu";

                hajsJanka = hajsJanka - wartoscZakladuJanka;
                pieniadzJanka.Content = $"Janek ma {hajsJanka} zł ";

                hajsBartka = hajsBartka - wartoscZakladuBartka;
                pieniadzBartka.Content = $"Bartek ma {hajsBartka} zł ";

                wartoscZakladuJanka = 0;
                Janek.Text = "Janek nie zawarł zakładu";

                wartoscZakladuBartka = 0;
                Bartek.Text = "Bartek nie zawarł zakładu";           
            }

            else
            {
                hajsJanka = hajsJanka - wartoscZakladuJanka;
                pieniadzJanka.Content = $"Janek ma {hajsJanka} zł ";

                hajsBartka = hajsBartka - wartoscZakladuBartka;
                pieniadzBartka.Content = $"Bartek ma {hajsBartka} zł ";

                hajsArka = hajsArka - wartoscZakladuArka;
                pieniadzArka.Content = $"Arek ma {hajsArka} zł ";

                wartoscZakladuArka = 0;
                Arek.Text = "Arek nie zawarł zakładu";

                wartoscZakladuJanka = 0;
                Janek.Text = "Janek nie zawarł zakładu";

                wartoscZakladuBartka = 0;
                Bartek.Text = "Bartek nie zawarł zakładu";            
            }
        }

        // On game ending

        private void koniecGry()
        {
            //Clear view
            MainView.Children.Clear();

            // Add a textblock

            TextBlock textBlock = new TextBlock();

            if (hajsJanka > hajsBartka && hajsJanka > hajsArka)
                textBlock.Text = "Koniec gry! Wygrał Janek";

            else if (hajsBartka > hajsJanka && hajsBartka > hajsArka)
                textBlock.Text = "Koniec gry! Wygrał Bartek";

            else if (hajsArka > hajsJanka && hajsArka > hajsBartka)
                textBlock.Text = "Koniec gry! Wygrał Arek";
            else
                textBlock.Text = "Koniec gry! Remis";

            textBlock.FontSize = 50; 

            textBlock.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock.VerticalAlignment = VerticalAlignment.Center; 

            MainView.Children.Add(textBlock); 
        }      
    }  
}
