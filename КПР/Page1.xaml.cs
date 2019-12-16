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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Model1 db;
        public Page1()
        {
            db = new Model1();
            InitializeComponent();
            this.DataContext = new AppViewModel();
            List<Client> clients = db.Client.ToList();
            // MessageBox.Show(clients.Count().ToString());
            dataGrid1.ItemsSource = clients;
        }

        private void abonementsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }



        private void ComboBoxClients(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
        }
    }
}
