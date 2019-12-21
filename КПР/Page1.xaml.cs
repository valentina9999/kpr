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
        int userId;
        public Page1()
        {
            InitializeComponent();
            db = new Model1();
            userId = 1;
            this.DataContext = new AppViewModel(userId);
            //List<Client> clients = db.Client.ToList();
            // MessageBox.Show(clients.Count().ToString());
            //dataGrid1.ItemsSource = clients;
         
        }
        public Page1(int user_id)
        {
            InitializeComponent();
            db = new Model1();
            userId = user_id;
            this.DataContext = new AppViewModel(userId);
            //List<Client> clients = db.Client.ToList();
            // MessageBox.Show(clients.Count().ToString());
            //dataGrid1.ItemsSource = clients;
         
        }

        private void abonementsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ClientsForm clientsForm = new ClientsForm();
            //clientsForm.Show();
            if (dataGrid1.SelectedItems.Count == 1)
            {
            var selectedClient = (dataGrid1.SelectedItems[0] as Client);
            //System.Windows.MessageBox.Show(selectedRealtyId);
            AddClientForm addClientForm = new AddClientForm(selectedClient);
            if (addClientForm.ShowDialog() == true)
                this.DataContext = new AppViewModel(userId);

            }
        }



        private void ComboBoxClients(object sender, SelectionChangedEventArgs e)
        {

        }
        Model1 dbcontext = new Model1();
        List<Client> allClient;
        List<User> allUser;
        List<Realty> allRealty;
        List<TypeRealty> allTypeRealty;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(userId);
            if (addClientForm.ShowDialog() == true)
                this.DataContext = new AppViewModel(userId);

            //AddClientForm f = new AddClientForm();
            ////DialogResult result = f.ShowDialog(this);

            ////if (result == DialogResult.Cancel)
            ////    return;

            //Client client = new Client();
            //client.Phones = f.txtPhones.Text;
            //client.Passport = f.txtPas.Text;
            //client.FIO = f.txtFIO.Text;
            //client.Address = f.txtAdd.Text;
            //// client.ID_client = 3;
            //client.ID_user_FK = 1;
            //dbcontext.Client.Add(client);

            //dataGrid1.Items.Refresh();
            //db.SaveChanges();

            //MessageBox.Show("Новый объект добавлен");
        }
    }
}
