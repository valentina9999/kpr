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
    /// Логика взаимодействия для AddAdDetails.xaml
    /// </summary>
    public partial class AddAdDetails : Window
    {
        Model1 db;
        int userId;
        int realtyId;
        public AddAdDetails(int user_id, int selectedRealtyId)
        {
            InitializeComponent();
            db = new Model1();
            realtyId = selectedRealtyId;
            userId = user_id;
            this.DataContext = new RealtiesViewModel(userId, realtyId);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
