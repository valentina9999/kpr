using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace КПР
{
    public class RealtiesViewModel : INotifyPropertyChanged
    {
        Model1 dbcontext = new Model1();
        private Model1 db;
        public string selectedTypeAdName { get; set; }
        private AdDetails selectedAdDetail;
        private Client selectedClient;
        public ObservableCollection<AdDetails> AdDetails { get; set; }
        public AdDetails SelectedAdDetail
        {
            get { return selectedAdDetail; }
            set
            {
                selectedAdDetail = value;
                selectedTypeAdName = selectedAdDetail.TypeAd.Name;
                OnPropertyChanged("SelectedAdDetail");
            }
        }
        public ObservableCollection<Client> Clients { get; set; }
        public Client SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }


        private DateTime selectedDate;
        public DateTime date
        {
            get { return selectedDate; }
            set
            {
                selectedDate = value;

                OnPropertyChanged("date");
            }
        }

        int userId;
        int idRealty;

        public DateTime Filing { get; set; }

        public int ID_typeAd_FK { get; set; }

        public int ID_realty_FK { get; set; }

        public int ID_client_FK { get; set; }

        private RelayCommand cmd;
        public RelayCommand InsertCommand
        {
            get
            {
                if (cmd == null) cmd = new RelayCommand(obj => {
                    addDetails();
                    System.Windows.MessageBox.Show("Запись добавлена!");

                });

                return cmd;
            }
            set
            {
                cmd = value;
            }
        }
        public void addDetails() 
        {
            db.AdDetails.Add(new AdDetails() { Filing = selectedDate, ID_adDetails = selectedAdDetail.ID_adDetails, ID_client_FK = selectedClient.ID_client, ID_realty_FK = idRealty, ID_typeAd_FK = selectedAdDetail.ID_typeAd_FK  });
            db.SaveChanges();
        }
        public RealtiesViewModel(int user_id, int id_realty)
        {
            db = new Model1();
            userId = user_id;
            idRealty = id_realty;
            AdDetails = new ObservableCollection<AdDetails>(db.AdDetails.ToList());
            SelectedAdDetail = db.AdDetails.FirstOrDefault();
            Clients = new ObservableCollection<Client>(db.Client.ToList());
            SelectedClient = db.Client.FirstOrDefault();
            date = DateTime.Now;
            //Client = new ObservableCollection<Client>(db.Client.ToList().Where(clnt => clnt.ID_user_FK == user_id));
            //Realty = new ObservableCollection<Realty>(db.Realty.ToList());
            //CBvalues = new ObservableCollection<string>();
            //CBvalues.Add("Мои клиенты".ToString());
            //CBvalues.Add("Все клиенты".ToString());
            //CBValue = CBvalues[0];
            //TypeRealty = new ObservableCollection<TypeRealty>(db.TypeRealty.ToList());
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
