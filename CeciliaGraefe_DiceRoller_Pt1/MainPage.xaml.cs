using System;
using System.Security.Cryptography;
using Windows.UI.Xaml.Controls;
using System.Diagnostics;

namespace CeciliaGraefeDiceRollerPt1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a <see cref="Frame">.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
        }

        Random randomNumberGenerator = new Random();

        private void TwoSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button TwoSidedDiceButton = (Button)sender;
            int result = randomNumberGenerator.Next(1,3);
            if (diceTotalOutput.Text == "0")
            {
                diceTotalOutput.Text = result.ToString();
                diceMathsOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void ThreeSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button ThreeSidedDiceButton = (Button)sender;
            int result = randomNumberGenerator.Next(1, 4);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void FourSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button fourSidedDiceButton = (Button)sender;
            int result = randomNumberGenerator.Next(1, 5);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void SixSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button sixSidedDiceButton = (Button)sender;
            int result = randomNumberGenerator.Next(1, 7);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void EightSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button eightSidedDiceButton = (Button)sender;
            int result = randomNumberGenerator.Next(1, 9);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void TenSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button tenSidedDiceButton = (Button)sender;
            int result = randomNumberGenerator.Next(1, 11);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void TwelveSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button twelveSidedDice = (Button)sender;
            int result = randomNumberGenerator.Next(1, 13);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void TwentySidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button twentySidedDice = (Button)sender;
            int result = randomNumberGenerator.Next(1, 21);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void HundredSidedDice_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button hundredSidedDice = (Button)sender;
            int result = randomNumberGenerator.Next(1, 101);
            if (diceTotalOutput.Text == "0")
            {
                diceMathsOutput.Text = result.ToString();
                diceTotalOutput.Text = result.ToString();
            }
            else
            {
                diceMathsOutput.Text += (" + " + result.ToString());
                diceTotalOutput.Text = (Int32.Parse(diceTotalOutput.Text) + result).ToString();
            }
        }

        private void ClearButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            diceTotalOutput.Text = "0";
            diceMathsOutput.Text= String.Empty;
        }
    }
}
