using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КПР
{
    class AppViewModel
    {
        private Model1 db;
        public ObservableCollection<Client> Client { get; set; }
        public ObservableCollection<Realty> Realty { get; set; }
        public AppViewModel()
        {
            db = new Model1();
            Client = new ObservableCollection<Client>(db.Client.ToList());
            Realty = new ObservableCollection<Realty>(db.Realty.ToList());

        }
    }
}
