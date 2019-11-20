using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
namespace КПР
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model1 db = new Model1();
            var request = db.User.ToList().Where(i => i.Login == txtLogin.Text && i.Password == txtPassword.Password).Count();
            if (request == 1)
            {
                Window1 mainWindow = new Window1();
                mainWindow.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Логин или пароль введены неправильно.");
                /*MessageBox mb = new MessageBox();
                mb.ShowDialog();*/
            }
        }
    }
}

