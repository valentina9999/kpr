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
        public Page3()
        {
            db = new Model1();
            InitializeComponent();
            this.DataContext = new AppViewModel();
            List<AdDetails> addetails = db.AdDetails.ToList();
            // MessageBox.Show(clients.Count().ToString());
            dataGrid3.ItemsSource = addetails;
        }

        private void dataGrid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
