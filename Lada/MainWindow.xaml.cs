using Olman;
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

namespace Lada
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Clikc(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Otrasl());
            Manager.MainFrame = MainFrame;
        }

        private void Btn_Clikc2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new otrasl2());
            Manager.MainFrame = MainFrame;
        }

        private void Btn_Clikc4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new material());
            Manager.MainFrame = MainFrame;
        }
    }
}
