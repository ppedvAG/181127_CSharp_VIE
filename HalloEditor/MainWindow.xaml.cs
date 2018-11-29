using Microsoft.Win32;
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
            #region FileStream
            //// System.IO 
            //FileStream stream = new FileStream("demo.txt", FileMode.Create);
            //byte[] data = Encoding.Default.GetBytes(textBoxInhalt.Text);
            //stream.Write(data, 0, data.Length);
            ////Flush -> Schreibbuffer
            //stream.Flush();
            //stream.Close(); 
            #endregion

            //StreamWriter sw = new StreamWriter("demo.txt");
            //sw.WriteLine(textBoxInhalt.Text);
            //sw.Flush();
            //sw.Close();

            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == true)
                File.WriteAllText(dlg.FileName, textBoxInhalt.Text);
        }

        private void MenuItemÖffnen_Click(object sender, RoutedEventArgs e)
        {
            #region FileStream
            //FileStream stream = new FileStream("demo.txt", FileMode.Open);

            //byte[] data = new byte[stream.Length];
            //int index = 0;
            //while (stream.CanRead)
            //{
            //    int value = stream.ReadByte();
            //    if (value != -1) // 255
            //        data[index] = (byte)value;
            //    else
            //        break;

            //    index++;
            //}
            //stream.Close(); 
            #endregion

            //StreamReader sr = new StreamReader("demo.txt");
            //textBoxInhalt.Text = sr.ReadToEnd();
            //sr.Close();

            OpenFileDialog dlg = new OpenFileDialog();
            // ... Eigenschaften
            if(dlg.ShowDialog() == true)
                textBoxInhalt.Text = File.ReadAllText(dlg.FileName);
        }

        private void MenuItemBeenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
            // Environment.Exit(0);
        }
    }
}
