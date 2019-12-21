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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        Model1 db;
        int userId;
        public Page3(int user_id)
        {
            db = new Model1();
            userId = user_id;
            InitializeComponent();
            this.DataContext = new AppViewModel(user_id);
            List<AdDetails> addetails = db.AdDetails.Where(ad => ad.Client.ID_user_FK == userId).ToList();
            // MessageBox.Show(clients.Count().ToString());
            dataGrid3.ItemsSource = addetails;
        }

        private void dataGrid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
