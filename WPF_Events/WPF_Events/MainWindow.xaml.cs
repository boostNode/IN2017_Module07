/*
 *  Author: Troy Davis
 *  Project: Module07 - Understanding Events and Event-Driven Programming - WPF Form Example - GUI
 *  Class: IN 2017 (Advanced C#)
 *  Date: Mar 07, 2017 
 *  Revision: Original
 */

using System.Windows;

namespace WPF_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_MyOtherClick;
        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            myOtherLabel.Content = "Hello again from myOther WPF Label!";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello WPF World!";
        }
    }
}
