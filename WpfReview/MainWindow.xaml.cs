using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var (X, Y) = (e.GetPosition(grid_mainView).X, e.GetPosition(grid_mainView).Y);
            //MessageBox.Show($"(x, y)=({X}, {Y})");
                        
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.Purple;
            ellipse.Width = 10;
            ellipse.Height = 10;
            ellipse.StrokeThickness = 2;

            _counter++;
            TextBlock tBlock = new TextBlock();
            tBlock.FontSize = 8;
            tBlock.FontWeight = FontWeights.Bold;
            tBlock.Text = $"Message {_counter}";
            
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Vertical;
            sp.Children.Add(ellipse);
            sp.Children.Add(tBlock);

            //cnv_locationsShower.Children.Add(ellipse);
            //Canvas.SetLeft(ellipse, X);
            //Canvas.SetTop(ellipse, Y);

            //cnv_locationsShower.Children.Add(tBlock); 
            //Canvas.SetLeft(tBlock, X);
            //Canvas.SetTop(tBlock, Y);

            cnv_locationsShower.Children.Add(sp);
            Canvas.SetLeft(sp, X);
            Canvas.SetTop(sp, Y);


        }
    }
}
