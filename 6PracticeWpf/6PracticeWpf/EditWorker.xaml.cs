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
    /// Логика взаимодействия для EditWorker.xaml
    /// </summary>
    public partial class EditWorker : Window
    {
        
        PracticeDBEntities db=new PracticeDBEntities();
        private WorkerWindow _window;
        
        public EditWorker( WorkerWindow _WorkerWindow)
        {
            
            InitializeComponent();
            _window = _WorkerWindow;
            RefreshWorkerInf();

           
        }
        
         public void RefreshWorkerInf()
        {
            
            foreach (Worker worker in db.Worker)
            {
                
                if (worker.Id == _window.workid)
                {
                    NameTb.Text = worker.Name;
                    SurnameTb.Text = worker.Surname;
                    MiddlenameTb.Text = worker.MiddleName;
                    GenderTb.Text = worker.Gender;
                    MaritalstatusTb.Text = worker.MaritalStatus;
                }
            }
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AcceptBtn.Content == "Добавить")
            {
                Worker worker = new Worker();
                worker.Name = NameTb.Text;
                worker.Surname = SurnameTb.Text;
                worker.MiddleName = MiddlenameTb.Text;
                worker.Gender = GenderTb.Text;
                worker.MaritalStatus = MaritalstatusTb.Text;
                db.Worker.Add(worker);
            }
            else
            {
                
                foreach (Worker worker in db.Worker)
                {

                    if (worker.Id == _window.workid)
                    {
                        worker.Name = NameTb.Text;
                        worker.Surname = SurnameTb.Text;
                        worker.MiddleName = MiddlenameTb.Text;
                        worker.Gender = GenderTb.Text;
                        worker.MaritalStatus = MaritalstatusTb.Text;
                    }
                }
            }
            
            db.SaveChanges();
            _window.RefreshWorkers();
            _window.workid = 0;
            this.Close();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
