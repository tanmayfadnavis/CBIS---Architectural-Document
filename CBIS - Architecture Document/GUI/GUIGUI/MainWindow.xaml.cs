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

namespace GUIGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            test.Items.Add("Package                                   Function                                             TestPassed\n");
            test.Items.Add("Parser                                    Parse                                                Yes\n");
            test.Items.Add("Rules                                     Detect Inheritance                              Yes\n");
            test.Items.Add("abc                                       Function1                                            No\n");
            test.Items.Add("Display                                   Funct1                                               Yes\n");
            test.Items.Add("XML                                       Show                                                 Yes\n");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

 
    }
}
