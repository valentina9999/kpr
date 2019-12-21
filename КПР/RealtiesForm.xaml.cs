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
using System.Windows.Shapes;

namespace КПР
{
    /// <summary>
    /// Логика взаимодействия для RealtiesForm.xaml
    /// </summary>
    public partial class RealtiesForm : Window
    {
        Model1 db;
        int realtyId;
        public RealtiesForm(int selectedRealtyId)
        {
            InitializeComponent();
            db = new Model1();
            realtyId = selectedRealtyId;
            //this.DataContext = new RealtiesViewModel(realtyId);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        Model1 dbcontext = new Model1();
        List<Client> allClient;
        List<User> allUser;
        List<Realty> allRealty;
        List<TypeRealty> allTypeRealty;
        List<TypeAd> allTypeAd;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //AddAdDetails addAdDetails = new AddAdDetails();
            //addAdDetails.Show();
            //AddAdDetails f = new AddAdDetails();
            //f.Realty.ItemsSource = allRealty;
            //f.Realty.DisplayMemberPath = "ID_Realty";
            //f.Realty.SelectedValuePath = "ID_Realty";

            //f.Client.ItemsSource = allClient;
            //f.Client.DisplayMemberPath = "FIO";
            //f.Client.SelectedValuePath = "ID_client";

            //f.Type.ItemsSource = allTypeAd;
            //f.Type.DisplayMemberPath = "Name";
            //f.Type.SelectedValuePath = "ID_typeAd";

            ////DialogResult result = f.ShowDialog(this);

            ////if (result == DialogResult.Cancel)
            ////    return;

            //AdDetails adDetails = new AdDetails();
            //adDetails.ID_realty_FK =(int) f.Realty.SelectedValue;
            //adDetails.ID_client_FK = (int)f.Client.SelectedValue;
            //adDetails.ID_typeAd_FK = (int)f.Type.SelectedValue;
            //adDetails.Filing =  (DateTime)f.Filing.SelectedDate;
            //dbcontext.AdDetails.Add(adDetails);

            //DataGrid4.Items.Refresh();
            //db.SaveChanges();

            //MessageBox.Show("Новый объект добавлен");
        }
    }
}
