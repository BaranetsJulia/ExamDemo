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
    /// Логика взаимодействия для Filtration.xaml
    /// </summary>
    public partial class Filtration : Page
    {
        DemoExEntities db;
        public Filtration()
        {
            InitializeComponent();
            combobind();
        }
        public List<Books> Books { get; set; }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            db = new DemoExEntities();
            dbB.ItemsSource = db.Books.ToList();
        }

        private void combobind()
        {
            DemoExEntities db = new DemoExEntities();
            var item = db.Books.ToList();
            Books = item;
            DataContext = Books;
        }

        //Фильтрация по автору
        private void cbB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dbB.ItemsSource = db.Books.Where(x => x.IdBook == cbB.SelectedIndex + 1).ToList();
        }

        private void Can_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frame.Navigate(new MiddlePage());
        }

        private void tbB_TextChanged(object sender, TextChangedEventArgs e)
        {
            dbB.ItemsSource = db.Books.Where(x => x.NameBook.Contains(tbB.Text)).ToList();
        }
    }
}
