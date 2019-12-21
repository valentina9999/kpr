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
    /// Логика взаимодействия для MyData.xaml
    /// </summary>
    public partial class MyData : Window
    {
        private int userId;

        public MyData()
        {
            InitializeComponent();
        }

        public MyData(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.DataContext = new MyDataViewModel(userId);
        }
    }
}
