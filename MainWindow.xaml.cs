using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace P1StenographJoe1
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
            Button btn = (Button)sender;
            
            if (OutputText.Text == "")
            {
                OutputText.Text = Upper(btn.Content.ToString()) + " ";
            } 

            else if (btn.Content.ToString() == "!")
            {
                OutputText.Text = Remove(OutputText.Text) + btn.Content.ToString() + " "; 
            }
            else if (OutputText.Text.EndsWith("! ") == true )
            {
                OutputText.Text += Upper(btn.Content.ToString()) + " ";
            }
            else
            {
                OutputText.Text += btn.Content.ToString() + " ";
            }

        }

        private string? Remove(string text)
        {
            text = OutputText.Text;
            return text = text.Trim();
            
        }

        private string Upper(string? v)
        {
            return char.ToUpper(v[0]) + v.Substring(1);
        }


        private void Rensa(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            OutputText.Text = "";
        }
       
    }
}
