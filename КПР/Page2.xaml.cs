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
        int userId;
        public Page2(int user_id)
        {
            db = new Model1();
            userId = user_id;
            InitializeComponent();
            this.DataContext = new AppViewModel(user_id);
            List<Realty> realties = db.Realty.ToList();
            // MessageBox.Show(clients.Count().ToString());
            dataGrid2.ItemsSource = realties;
        }
        Model1 dbcontext = new Model1();
        List<Client> allClient;
        List<User> allUser;
        List<Realty> allRealty;
        List<TypeRealty> allTypeRealty;
        List<StatusRealty> allStatusRealty;

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            AddRealtyForm addrealtyform = new AddRealtyForm();
            addrealtyform.Show();
            //AddRealtyForm f = new AddRealtyForm();
            //f.Type.ItemsSource = allTypeRealty;
            //f.Type.DisplayMemberPath = "Name";
            //f.Type.SelectedValuePath = "ID_TypeRealty";

            //f.Status.ItemsSource = allStatusRealty; ;
            //f.Status.DisplayMemberPath = "Name";
            //f.Status.SelectedValuePath = "ID_statusRealty";

            //f.Prod.ItemsSource = allClient;
            //f.Prod.DisplayMemberPath = "FIO";
            //f.Prod.SelectedValuePath= "ID_client";

            ////DialogResult result = f.ShowDialog(this);

            ////if (result == DialogResult.Cancel)
            ////    return;

            //Realty realty = new Realty();
            //realty.Address = f.txtAd.Text;
            //realty.Price = 1;
            //realty.Space = 1;
            //realty.ID_client_FK = (int)f.Prod.SelectedValue;
            //realty.ID_StatusRealty_FK = (int)f.Status.SelectedValue;
            //realty.ID_TypeRealty_FK = (int)f.Type.SelectedValue;

            //dbcontext.Realty.Add(realty);

            //dataGrid2.Items.Refresh();
            //db.SaveChanges();

            //MessageBox.Show("Новый объект добавлен");
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedRealtyId = (dataGrid2.SelectedItems[0] as Realty).ID_realty;
            //System.Windows.MessageBox.Show(selectedRealtyId);
            AddAdDetails realtiesForm = new AddAdDetails(userId, selectedRealtyId);
            if (realtiesForm.ShowDialog() == true)
            {
                AddRealtyForm addrealtyform = new AddRealtyForm();
            }

        }
    }
}
