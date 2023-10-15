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

namespace Wpf_Task1
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

        private void one_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = Convert.ToString(one.Content);
            grid.Children.Remove(sender as Button);
        }
        private void two_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = Convert.ToString(two.Content);
            grid.Children.Remove(sender as Button);
        }
        private void three_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = Convert.ToString(three.Content);
            grid.Children.Remove(sender as Button);
        }
        private void four_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = Convert.ToString(four.Content);
            grid.Children.Remove(sender as Button);
        }
        private void five_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = Convert.ToString(five.Content);
            grid.Children.Remove(sender as Button);
        }
        private void six_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = Convert.ToString(six.Content);
            grid.Children.Remove(sender as Button);
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            byte[] colors = new byte[3];
            colors[0] = (byte)Random.Shared.Next(0, 255);
            colors[1] = (byte)Random.Shared.Next(0, 255);
            colors[2] = (byte)Random.Shared.Next(0, 255);

            one.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(colors[0], colors[1], colors[2])
            };
            MessageBox.Show($"Content: {one.Content}\nName: {one.Name}\nColor: {one.Background}\n Height: {one.Height}\nWidth: {one.Width}");
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            byte[] colors = new byte[3];
            colors[0] = (byte)Random.Shared.Next(0, 255);
            colors[1] = (byte)Random.Shared.Next(0, 255);
            colors[2] = (byte)Random.Shared.Next(0, 255);

            two.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(colors[0], colors[1], colors[2])
            };
            MessageBox.Show($"Content: {two.Content}\nName: {two.Name}\nColor: {two.Background}\n Height: {two.Height}\nWidth: {two.Width}");
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            byte[] colors = new byte[3];
            colors[0] = (byte)Random.Shared.Next(0, 255);
            colors[1] = (byte)Random.Shared.Next(0, 255);
            colors[2] = (byte)Random.Shared.Next(0, 255);

            three.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(colors[0], colors[1], colors[2])
            };
            MessageBox.Show($"Content: {three.Content}\nName: {three.Name}\nColor: {three.Background}\n Height: {three.Height}\nWidth: {three.Width}");
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            byte[] colors = new byte[3];
            colors[0] = (byte)Random.Shared.Next(0, 255);
            colors[1] = (byte)Random.Shared.Next(0, 255);
            colors[2] = (byte)Random.Shared.Next(0, 255);

            four.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(colors[0], colors[1], colors[2])
            };
            MessageBox.Show($"Content: {four.Content}\nName: {four.Name}\nColor: {four.Background}\n Height: {four.Height}\nWidth: {four.Width}");
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            byte[] colors = new byte[3];
            colors[0] = (byte)Random.Shared.Next(0, 255);
            colors[1] = (byte)Random.Shared.Next(0, 255);
            colors[2] = (byte)Random.Shared.Next(0, 255);

            five.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(colors[0], colors[1], colors[2])
            };
            MessageBox.Show($"Content: {five.Content}\nName: {five.Name}\nColor: {five.Background}\n Height: {five.Height}\nWidth: {five.Width}");
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            byte[] colors = new byte[3];
            colors[0] = (byte)Random.Shared.Next(0, 255);
            colors[1] = (byte)Random.Shared.Next(0, 255);
            colors[2] = (byte)Random.Shared.Next(0, 255);

            six.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(colors[0], colors[1], colors[2])
            };
            MessageBox.Show($"Content: {six.Content}\nName: {six.Name}\nColor: {six.Background}\n Height: {six.Height}\nWidth: {six.Width}");
        }
    }
}
