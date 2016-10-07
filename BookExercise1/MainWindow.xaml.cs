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
        double sq;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            frameworkLabel.Content = toString(calculateSQ(numberDouble));
        }

        private void inputTestBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // convert Textbox input into a double

            if (!Double.TryParse(inputTestBox.Text, out numberDouble))
            {
                MessageBox.Show("Please enter a number");
                return;
            }
           

                Double.TryParse(inputTestBox.Text, out numberDouble);
                if (numberDouble < 0) MessageBox.Show("Please enter a positiv number");
                else return;

                

            
        }
        private String toString(double d)
        {
            return d.ToString("00.000 (Using .NET Framework)");
        }

        private double calculateSQ(double d)
        {
           return sq = Math.Sqrt(numberDouble);
        }
    }
}