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

namespace Keyboard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<char>keykup = new List<char>() {'q','w','e' };
        }

        private void TextBlock_KeyDown(object sender, KeyEventArgs e)
        {
            textBlock1.Text += e.Key.ToString();
        }

        private void Difficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textDifficulty.Text= ((int)e.NewValue).ToString();
        }
    }
}
