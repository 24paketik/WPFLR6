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

namespace WpfLR6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point p;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void rect1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.Source == canvas1)
                return;
            var a = e.Source as Rectangle;
            p = e.GetPosition(a);
        }

        private void rect1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Source == canvas1)
            {
                Title = "Mouse";
                return;
            }
            var a = e.Source as Rectangle;
            Point q = e.GetPosition(a);
            Title = String.Format("Mouse - {0} {1}", a.Name, q);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Canvas.SetLeft(a, Canvas.GetLeft(a) + q.X - p.X);
                Canvas.SetTop(a, Canvas.GetTop(a)+q.Y - p.Y);
            }
        }
    }
}
