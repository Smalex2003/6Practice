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
using Word = Microsoft.Office.Interop.Word;


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
        /// <summary>
        /// Метод обновления таблицы.
        /// </summary>
        public void RefreshPost()
        {
           PracticeDBEntities db = new PracticeDBEntities();
            PostGrid.ItemsSource = db.Post.ToList();
        }
        public void BtnDeletePost_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PracticeDBEntities db = new PracticeDBEntities();
                Post _post;
                _post = (sender as Button).DataContext as Post;
                string message = "Должность с кодом " + Convert.ToString(_post.Id) + " будет удалена";
                string caption = "Удаление";                 // заголовок окна

                //DialogResult result = MessageBox.Show(this, message, caption, MessageBoxButton.OKCancel,MessageBoxImage.Question);
                var result = MessageBox.Show(this, message, caption, MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
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
                        if (post.Id == _post.Id)
                        {
                            db.Post.Remove(post);

                        }
                    }


                    db.SaveChanges();
                    RefreshPost();
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }


        private void PdfBtn_Click(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// Работа с сохранение отчета в pdf файл.
            /// </summary>
            try
            {
                PracticeDBEntities db = new PracticeDBEntities();
                Word.Application app = new Word.Application();
                Word.Document doc = app.Documents.Add();
                Word.Paragraph pardo = doc.Paragraphs.Add();
                Word.Range pardorange = pardo.Range;
                pardorange.Text = "Отчёт о должностях";
                pardorange.Font.Size = 22;
                pardo.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                pardorange.InsertParagraphAfter();
                Word.Paragraph par = doc.Paragraphs.Add();
                Word.Range range = par.Range;
                Word.Table table = doc.Tables.Add(range, db.Post.ToList().Count + 1, 6);
                table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                int rowcount = 1;
                table.Cell(rowcount, 1).Range.Text = "Код должности";
                table.Cell(rowcount, 2).Range.Text = "Название";
                table.Cell(rowcount, 3).Range.Text = "Краткое название";
                table.Cell(rowcount, 4).Range.Text = "Шифр";
                table.Cell(rowcount, 5).Range.Text = "Максимальный разряд";
                table.Cell(rowcount, 6).Range.Text = "Минимальный разряд";
                table.Rows[1].Range.Font.Size = 14;
                table.Rows[1].Range.Bold = 1;
                rowcount++;
                foreach (Post item in db.Post)
                {
                    table.Cell(rowcount, 1).Range.Text = item.Id.ToString();
                    table.Cell(rowcount, 2).Range.Text = item.Name;
                    table.Cell(rowcount, 3).Range.Text = item.ShortName;
                    table.Cell(rowcount, 4).Range.Text = item.Cipher;
                    table.Cell(rowcount, 5).Range.Text = item.UpperDischargeLevel.ToString();
                    table.Cell(rowcount, 6).Range.Text = item.LowerDischargeLeve.ToString();
                    rowcount++;
                }
                table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                table.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                table.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
                table.Range.ParagraphFormat.SpaceAfter = 0.0f;
                table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
                table.Range.Font.Name = "Comic Sans MS";
                doc.SaveAs2(@"C:\PDF\document.pdf", Word.WdSaveFormat.wdFormatPDF);
                app.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }
    }
}
