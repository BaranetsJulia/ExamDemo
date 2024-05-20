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

namespace ExamDemo
{
    /// <summary>
    /// Логика взаимодействия для DataManagement.xaml
    /// </summary>
    public partial class DataManagement : Page
    {
        DemoExEntities db;
        public DataManagement()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            db = new DemoExEntities();
            dbBook.ItemsSource = db.Books.ToList();
        }
        //Добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Books books = new Books();
            books.IdBook = Convert.ToInt32(id.Text);
            books.NameBook = name.Text;
            books.Author = name.Text;
            books.ReleaseDate = Convert.ToDateTime(dateRel.Text);
            books.Cost = Convert.ToInt32(cost.Text);
            db.Books.Add(books);
            db.SaveChanges();
            dbBook.ItemsSource = db.Books.ToList();
        }
        //Изменение
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int sUPid = Convert.ToInt32(id.Text);
            var selectedId = db.Books.Where(w => w.IdBook == sUPid).FirstOrDefault();
            selectedId.IdBook = Convert.ToInt32(id.Text);
            selectedId.NameBook = name.Text;
            selectedId.Author = name.Text;
            selectedId.ReleaseDate = Convert.ToDateTime(dateRel.Text);
            selectedId.Cost = Convert.ToInt32(cost.Text);
            db.SaveChanges();
            dbBook.ItemsSource = db.Books.ToList();
        }
        //Удаление
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            int sDid = Convert.ToInt32(id.Text);
            var selecteDId = db.Books.Where(w => w.IdBook == sDid).FirstOrDefault();
            db.Books.Remove(selecteDId);
            db.SaveChanges();
            dbBook.ItemsSource = db.Books.ToList();
        }

        //Переход на промежуточную страницу
        private void Can_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frame.Navigate(new MiddlePage());
        }
    }
}
