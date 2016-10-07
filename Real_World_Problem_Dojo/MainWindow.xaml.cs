using Shapes;
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


namespace Real_World_Problem_Dojo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { //test
        public MainWindow()
        {
            InitializeComponent();

            Rectangle rect = new Rectangle() { Height = 150, Width = 70, Stroke = new SolidColorBrush(Colors.Black) };

            paper.Children.Add(rect);
            Canvas.SetTop(rect, 100);
            Canvas.SetLeft(rect, 100);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            int rndNumber = rnd.Next(0, 5);
            Shapes.Shape shape=null;

            switch (rndNumber)
            {
                case 0:
                    shape = new Circle() { CurrentPosition = new Point(rnd.Next(0, 5), (rnd.Next(0, 5)), Diameter = 75) };
                    break;
                default:
                    break;
            }

            shape.Draw(paper);
        }
    }
}
