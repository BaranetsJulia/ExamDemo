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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        DemoExEntities db;
        public Autorization()
        {
            InitializeComponent();
        }

        //Ааторизация
        private void SignIn_Button(object sender, RoutedEventArgs e)
        {
            db = new DemoExEntities();
           
            var user = db.Users.Where(d => (d.Login == Login.Text && d.Password == Password.Password)).FirstOrDefault();
            if(user != null)
            {
                Navigation.frame.Navigate(new MiddlePage());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
