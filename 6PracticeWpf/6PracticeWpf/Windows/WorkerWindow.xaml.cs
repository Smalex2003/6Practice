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
using System.Windows.Shapes;

namespace _6PracticeWpf
{
    
    /// <summary>
    /// Логика взаимодействия для WorkerWindow.xaml
    /// </summary>
    public partial class WorkerWindow : Window
    {
        
        
        public WorkerWindow()
        {
            PracticeDBEntities db = new PracticeDBEntities();
            InitializeComponent();
            RefreshWorkers();
            

        }
        public int workid;
        /// <summary>
        /// Метод обновления таблицы.
        /// </summary>
        public void RefreshWorkers()
        {
            PracticeDBEntities _db = new PracticeDBEntities();
            GridWorkers.ItemsSource = _db.Worker.ToList();
        }
        
        private void BtnEditWorker_Click(object sender, RoutedEventArgs e)
        {
            
            Worker _worker;
            _worker = (sender as Button).DataContext as Worker;
            workid=_worker.Id;
            EditWorker editWorker = new EditWorker(this);
            editWorker.ShowDialog();
        }

        private void AddworkerBtn_Click(object sender, RoutedEventArgs e)
        {
            EditWorker editworker = new EditWorker(this);
            editworker.AcceptBtn.Content = "Добавить";
            editworker.ShowDialog();
        }
    }
}
