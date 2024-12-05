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

namespace szarvasmarhatelep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string [] napok = { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat", "Vasárnap" };
            foreach (var item in napok)
            {
                cBox1.Items.Add(item);
            }
            cBox1.SelectedIndex = 0;

            slider.Value = 15;
        }
        
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
        }
    }
}
