using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПР
{
    public class AppViewModel : INotifyPropertyChanged
    {
        Model1 dbcontext = new Model1();
        private Model1 db;
        int userId;
        private string cbvalue;

        public ObservableCollection<Client> Client { get; set; }
        public ObservableCollection<Realty> Realty { get; set; }
        // public ObservableCollection<TypeRealty> TypeRealty { get; set; }
        public ObservableCollection<string> CBvalues { get; set; }
        public string CBValue {
            get { return cbvalue; }
            set
            {
                cbvalue = value;
                List<Client> tmpList;
                if (cbvalue == "Все клиенты")
                {
                    tmpList = db.Client.ToList();
                }
                else
                {
                    tmpList = db.Client.Where(clnt => clnt.ID_user_FK == userId).ToList();
                }
                Client.Clear();
                tmpList.ForEach(clnt =>
                {
                    Client.Add(clnt);
                });
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("CBValue"));
            }
        }
        public AppViewModel(int user_id)
        {
            db = new Model1();
            userId = user_id;
            Client = new ObservableCollection<Client>(db.Client.ToList().Where(clnt => clnt.ID_user_FK == user_id));
            Realty = new ObservableCollection<Realty>(db.Realty.ToList());
            CBvalues = new ObservableCollection<string>();
            CBvalues.Add("Мои клиенты".ToString());
            CBvalues.Add("Все клиенты".ToString());
            CBValue = CBvalues[0];
            //TypeRealty = new ObservableCollection<TypeRealty>(db.TypeRealty.ToList());
        }
        public void Create(Client Client)
        {
            db.Client.Add(Client);
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
