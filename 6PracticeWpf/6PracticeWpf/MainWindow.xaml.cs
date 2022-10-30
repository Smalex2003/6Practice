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

namespace _6PracticeWpf
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

        private void WorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            WorkerWindow workwind = new WorkerWindow();
            workwind.Show();
        }

        private void WorkerBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            PostWindow postwindow = new PostWindow();
            postwindow.Show();
        }
    }
}
