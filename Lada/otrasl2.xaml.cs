using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Olman
{
    /// <summary>
    /// Логика взаимодействия для otrasl2.xaml
    /// </summary>
    public partial class otrasl2 : Page
    {
        public otrasl2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://rubble2004.github.io/Roboflow/");
            Process.Start("https://github.com/Rubble2004/Roboflow");
        }
    }
}
