using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПР
{
    public class AddClientViewModel : INotifyPropertyChanged
    {
        Model1 dbcontext = new Model1();
        private Model1 db;
        int userId;

        public string phone { get; set; }
        public string pas { get; set; }
        public string FIO { get; set; }
        public string address { get; set; }

        private int clientId = 0;
        private RelayCommand cmd;

        public RelayCommand InsertCommand
        {
            get
            {
                if (cmd == null) cmd = new RelayCommand(obj => {
                    addClient();
                    System.Windows.MessageBox.Show("Запись добавлена!");

                });

                return cmd;
            }
            set
            {
                cmd = value;
            }
        }
        public void addClient() 
        {
            Client cl = db.Client.Where(i => i.ID_client == clientId).FirstOrDefault();
            if (cl == null)
            {
            db.Client.Add(new Client() { FIO = FIO, ID_user_FK = userId, Address = address, Passport = pas, Phones = phone });

            }
            else
            {
                cl.FIO = FIO;
                cl.Phones = phone;
                cl.Address = address;
                cl.Passport = pas;
            } 
            db.SaveChanges();
        }
        public AddClientViewModel(int user_id)
        {
            db = new Model1();
            userId = user_id;
            //Client = new ObservableCollection<Client>(db.Client.ToList().Where(clnt => clnt.ID_user_FK == user_id));
            //Realty = new ObservableCollection<Realty>(db.Realty.ToList());
            //CBvalues = new ObservableCollection<string>();
            //CBvalues.Add("Мои клиенты".ToString());
            //CBvalues.Add("Все клиенты".ToString());
            //CBValue = CBvalues[0];
            //TypeRealty = new ObservableCollection<TypeRealty>(db.TypeRealty.ToList());
        }

        public AddClientViewModel(Client selectedClient)
        {
            db = new Model1();
            userId = selectedClient.ID_user_FK;
            phone = selectedClient.Phones;
            FIO = selectedClient.FIO;
            pas = selectedClient.Passport;
            address = selectedClient.Address;
            clientId = selectedClient.ID_client;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
