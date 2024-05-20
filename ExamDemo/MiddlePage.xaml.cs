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
    /// Логика взаимодействия для MiddlePage.xaml
    /// </summary>
    public partial class MiddlePage : Page //Промежуточная страница
    {
        public MiddlePage()
        {
            InitializeComponent();
        }

        //Переход на страницу для управления данными
        private void DM_Button(object sender, RoutedEventArgs e)
        {
            Navigation.frame.Navigate(new DataManagement());
        }

        //Переход на страницу фильтрации данных
        private void Filtr_Button(object sender, RoutedEventArgs e)
        {
            Navigation.frame.Navigate(new Filtration());
        }

        //Переход на страницу авторизации
        private void Can_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frame.Navigate(new Autorization());
        }
    }
}
