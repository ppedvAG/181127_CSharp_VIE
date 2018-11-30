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

namespace WPFMediaElement
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaElementDemo.Source = new Uri(@"C:\Users\mz1-dev\Downloads\kurz.mp4");
            mediaElementDemo.LoadedBehavior = MediaState.Manual;
            mediaElementDemo.Play();
            // MessageBox.Show(mediaElementDemo.HasVideo.ToString());
            imagePlaceholder.Visibility = Visibility.Hidden;
        }

        private void MediaElementDemo_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaElementDemo.Stop(); // macht Reset
            mediaElementDemo.Play();
        }
    }
}
