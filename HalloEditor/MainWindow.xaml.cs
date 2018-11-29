using System;
using System.Collections.Generic;
using System.IO;
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

namespace HalloEditor
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

        private void MenuItemSpeichern_Click(object sender, RoutedEventArgs e)
        {
            // System.IO 
            FileStream stream = new FileStream("demo.txt", FileMode.Create);
            byte[] data = Encoding.Default.GetBytes(textBoxInhalt.Text);
            stream.Write(data, 0, data.Length);
            //Flush -> Schreibbuffer
            stream.Flush();
            stream.Close();
        }

        private void MenuItemÖffnen_Click(object sender, RoutedEventArgs e)
        {
            FileStream stream = new FileStream("demo.txt", FileMode.Open);

            byte[] data = new byte[stream.Length];
            int index = 0;
            while (stream.CanRead)
            {
                int value = stream.ReadByte();
                if (value != -1) // 255
                    data[index] = (byte)value;
                else
                    break;

                index++;
            }
            stream.Close();

            textBoxInhalt.Text =  Encoding.Default.GetString(data);
        }

        private void MenuItemBeenden_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
