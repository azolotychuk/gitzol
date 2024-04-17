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

namespace FIT
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClubStaf cstf = new ClubStaf();
            cstf.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Programs pr = new Programs();
            pr.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ClubMembers club = new ClubMembers();
            club.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           RecordSheet  rsh = new RecordSheet();
           rsh.Show();
        }
    }
}
