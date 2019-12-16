using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        Model1 db;
        public Page2()
        {
            db = new Model1();
            InitializeComponent();
            this.DataContext = new AppViewModel();
            List<Realty> realties = db.Realty.ToList();
            // MessageBox.Show(clients.Count().ToString());
            dataGrid2.ItemsSource = realties;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            AddRealtyForm addrealtyform = new AddRealtyForm();
            addrealtyform.Show();
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RealtiesForm realtiesForm = new RealtiesForm();
            realtiesForm.Show();
        }
    }
}
