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
    /// Логика взаимодействия для AddClientForm.xaml
    /// </summary>
    public partial class AddClientForm : Window
    {
        private int userId;

        public AddClientForm(int user_id)
        {
            InitializeComponent();
            this.DataContext = new AddClientViewModel(user_id);
            userId = user_id;
        }

        public AddClientForm(Client selectedClient)
        {
            InitializeComponent();
            this.DataContext = new AddClientViewModel(selectedClient);
            userId = selectedClient.ID_user_FK;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
