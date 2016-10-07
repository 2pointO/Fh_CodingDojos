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

namespace BookExercise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       double numberDouble;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {

            if (!Double.TryParse(inputTestBox.Text, out numberDouble))
            {
                MessageBox.Show("Please enter a double number");
                return;
            }

            if (numberDouble < 0) MessageBox.Show("Please enter a positiv number");

            double sq = Math.Sqrt(numberDouble);

            frameworkLabel.Content = string.Format("{0} (Using the .Net Framework)", sq);

            decimal numberDecimal;
            if (!Decimal.TryParse(inputTestBox.Text, out numberDecimal))
            {
                MessageBox.Show("Please enter a decimal number");
                return;
            }

            decimal delta = Convert.ToDecimal(Math.Pow(10, -28));
            decimal guess = numberDecimal / 2;
            decimal result = ((numberDecimal / guess) + guess) / 2;

            while (Math.Abs(result - guess) > delta)
            {
                guess = result;
                result = ((numberDecimal / guess) + guess) / 2;
            }

            newtonLabel.Content = string.Format("{0} (Using Newton)", result);
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            int intNumber;

            if(!int.TryParse(textBox.Text, out intNumber))
            {
                MessageBox.Show("Enter an integer");
                return;
            }

            if (intNumber < 0) MessageBox.Show("Please enter a positive number");
            
            int remainder = 0;
            StringBuilder binary = new StringBuilder();

            do
            {
                remainder = intNumber % 2;
                intNumber = intNumber / 2;
                binary.Insert(0,remainder);

            } while (intNumber > 0);

            label.Content = binary.ToString();
        }

        private void inputTestBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}