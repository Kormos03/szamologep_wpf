using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szamologep_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float globalInp1;
        public float globalInp2;
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool ellenorzes()
        {
            var inp1 = input1.Text;
            var inp2 = input2.Text;
            if (Single.TryParse(inp1, out float number1) && Single.TryParse(inp2, out float number2))
            {
                globalInp1 = number1;
                globalInp2 = number2;
                return true;
            }
            else
            {

                eredmeny.Text = "";
                MessageBox.Show("Nem megfelelő a beviteli érték!");
                return false;
            }
        }
        private void osszeadas_Click(object sender, RoutedEventArgs e)
        {
            if(ellenorzes() == false) 
            {
                return;
            }
            eredmeny.Text = (globalInp1 + globalInp2).ToString();
        }

        private void kivonas_Click(object sender, RoutedEventArgs e)
        {
            if (ellenorzes() == false)
            {
                return;
            }
            eredmeny.Text = (globalInp1 - globalInp2).ToString();
        }

        private void szorzas_Click(object sender, RoutedEventArgs e)
        {
            if (ellenorzes() == false)
            {
                return;
            }
            eredmeny.Text = (globalInp1 * globalInp2).ToString();
        }

        private void osztas_Click(object sender, RoutedEventArgs e)
        {
            if (ellenorzes() == false)
            {
                return;
            }
            eredmeny.Text = (globalInp1 / globalInp2).ToString();
        }

        private void maradekos_Click(object sender, RoutedEventArgs e)
        {
            if (ellenorzes() == false)
            {
                return;
            }
            eredmeny.Text = (globalInp1 % globalInp2).ToString();
        }
    }
}
