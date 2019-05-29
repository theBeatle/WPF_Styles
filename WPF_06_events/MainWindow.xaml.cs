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

namespace WPF_06_events
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
        private void Element_MouseEnter(object sender, MouseEventArgs e)
        {
            //((TextBlock)sender).Background = new SolidColorBrush(Colors.LightGoldenrodYellow);
            if (sender is Label)
            {
                (sender as Label).Background = new SolidColorBrush(Colors.LightGoldenrodYellow);
                (sender as Label).Foreground = new SolidColorBrush(Colors.OrangeRed);
            }
            if (sender is TextBlock)
            {
                (sender as TextBlock).Background = new SolidColorBrush(Colors.LightGoldenrodYellow);
                (sender as TextBlock).Foreground = new SolidColorBrush(Colors.OrangeRed);
            }
            if (sender is Button)
            {
                Button myBut = sender as Button;
                myBut.Background = new SolidColorBrush(Colors.ForestGreen);
                myBut.Foreground = new SolidColorBrush(Colors.OrangeRed);
                myBut.FontWeight = FontWeights.ExtraBold;
            }
        }

        private void Element_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Label)
            {
                (sender as Label).Background = null;
                (sender as Label).Foreground = this.Foreground;

            }
            if (sender is TextBlock)
            {
                (sender as TextBlock).Background = null;
                (sender as TextBlock).Foreground = this.Foreground;
            }
            if (sender is Button)
            {
                Button myBut = sender as Button;
                myBut.Background = new SolidColorBrush(Colors.Gray);
                myBut.Foreground = new SolidColorBrush(Colors.Black);
                myBut.FontWeight = FontWeights.Normal;
            }
        }


    }
}
