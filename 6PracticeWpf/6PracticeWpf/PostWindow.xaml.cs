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
    /// Логика взаимодействия для PostWindow.xaml
    /// </summary>
    public partial class PostWindow : Window
    {
        
        public PostWindow()
        {
            
            InitializeComponent();
            RefreshPost();
        }
        public void RefreshPost()
        {
           PracticeDBEntities db = new PracticeDBEntities();
            PostGrid.ItemsSource = db.Post.ToList();
        }
        private void BtnDeletePost_Click(object sender, RoutedEventArgs e)
        {
            PracticeDBEntities db = new PracticeDBEntities();
            Post _post;
            _post = (sender as Button).DataContext as Post;
            foreach (PosistionList positionlist in db.PosistionList)
            {
                if (positionlist.PostId == _post.Id)
                {
                    db.PosistionList.Remove(positionlist);
                }
            }
            foreach (WorkingPeriod workingperiod in db.WorkingPeriod)
            {
                if (workingperiod.PostId == _post.Id)
                {
                    db.WorkingPeriod.Remove(workingperiod);
                }
            }
            foreach (Post post in db.Post)
            {
                if(post.Id == _post.Id)
                {
                    db.Post.Remove(post);
                
                }
            }
            
           
            db.SaveChanges();
            RefreshPost();
        }
    }
}
