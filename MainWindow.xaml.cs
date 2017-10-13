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

namespace WpfApplication3
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
        int count1 = 0;
        private void Button_Click(object sender, RoutedEventArgs e) //function definition for Count button
        {
            count1++; //increment on every click

            string c = count1.ToString(); //conversion to string
            count.Text=c;// replacing text with current count value
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            count1 = 0;
            count.Text = count1.ToString(); //setting counter value to 0
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close(); //closing the window
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (hellob.IsChecked == true)
            {
                MessageBox.Show("Hello");
            }
            else if (byeb.IsChecked == true)
            {
                MessageBox.Show("Bye");
            }*/

        }
    }

