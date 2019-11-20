namespace КПР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdDetails
    {
        [Key]
        public int ID_adDetails { get; set; }

        public DateTime Filing { get; set; }

        public int ID_typeAd_FK { get; set; }

        public int ID_realty_FK { get; set; }

        public int ID_client_FK { get; set; }

        public virtual Client Client { get; set; }

        public virtual Realty Realty { get; set; }

        public virtual TypeAd TypeAd { get; set; }
    }
}
