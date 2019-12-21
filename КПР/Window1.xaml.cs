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

namespace КПР
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int userId;
        NavigationService nav;
        public Window1(int user_id)
        {
            InitializeComponent();
            userId = user_id;
        }
        public Window1()
        {
            //Uri iconUri = new Uri("pack://siteoforigin:,,,/icon1.ico", UriKind.RelativeOrAbsolute);
            //this.Icon = BitmapFrame.Create(iconUri);
            InitializeComponent();
            userId = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clients.Content = new Page1(userId);
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clients.Content = new Page2(userId);
            //nav = NavigationService.GetNavigationService((Page1)Clients.Content);
            //Page2 page2 = new Page2();
            //nav.Navigate(page2);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Clients.Content = new Page3(userId);
            //nav = NavigationService.GetNavigationService((Page2)Clients.Content);
            //Page3 page3 = new Page3();
            //nav.Navigate(page3);
            //Clients.Content = new MyData();
        }

        private void Clients_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MyData myData = new MyData(userId);
            if (myData.ShowDialog() == true)
            {
                return;
            }
        }
    }
}
