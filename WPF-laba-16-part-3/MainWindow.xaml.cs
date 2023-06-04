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

namespace WPF_laba_16_part_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = InputTextBox.Text;
            string[] words = inputText.Split(' ');

            foreach (string word in words)
            {
                ChildWindow childWindow = new ChildWindow(word);
                childWindow.Show();
            }
        }
    }
}
