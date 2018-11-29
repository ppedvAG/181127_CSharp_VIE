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

namespace HalloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBoxObst.Items.Add("Hallo Welt");
            comboBoxObst.Items.Add(12.5);
            comboBoxObst.Items.Add(new TextBox { Height = 25, Width = 200 });

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    buttonKlickMich.Background = new SolidColorBrush(Colors.Lavender);
        //    MessageBox.Show("Hello World");
        //}
    }
}
