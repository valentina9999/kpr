using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПР
{
    public class MyDataViewModel : INotifyPropertyChanged
    {
        Model1 dbcontext = new Model1();
        private Model1 db;
        int userId;

        public string FIO { get; set; }
        public int AdDetailCount { get; set; }
        public double totalMoney { get; set; }
        public string Login { get; set; }

        private int clientId = 0;
        
        public MyDataViewModel(int user_id)
        {
            db = new Model1();
            userId = user_id;
            FIO = db.User.FirstOrDefault(u => u.ID_user == user_id).FIO;
            Login = db.User.FirstOrDefault(u => u.ID_user == user_id).Login;
            AdDetailCount = db.AdDetails.Where(ad => ad.Client.ID_user_FK == user_id).Count();
            //totalMoney = db.Realty.Where(r => r.Client.ID_user_FK == userId).Sum(r => r.Price) / 20;
            totalMoney = db.Client.FirstOrDefault(c => c.ID_user_FK == userId).Realty.Sum(r => r.Price) / 20;
            //Client = new ObservableCollection<Client>(db.Client.ToList().Where(clnt => clnt.ID_user_FK == user_id));
            //Realty = new ObservableCollection<Realty>(db.Realty.ToList());
            //CBvalues = new ObservableCollection<string>();
            //CBvalues.Add("Мои клиенты".ToString());
            //CBvalues.Add("Все клиенты".ToString());
            //CBValue = CBvalues[0];
            //TypeRealty = new ObservableCollection<TypeRealty>(db.TypeRealty.ToList());
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
