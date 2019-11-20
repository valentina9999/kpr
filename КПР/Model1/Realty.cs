namespace КПР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Realty")]
    public partial class Realty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Realty()
        {
            AdDetails = new HashSet<AdDetails>();
        }

        [Key]
        public int ID_realty { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public double Price { get; set; }

        public int Space { get; set; }

        public int ID_TypeRealty_FK { get; set; }

        public int ID_StatusRealty_FK { get; set; }

        public int ID_client_FK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdDetails> AdDetails { get; set; }

        public virtual Client Client { get; set; }

        public virtual StatusRealty StatusRealty { get; set; }

        public virtual TypeRealty TypeRealty { get; set; }
    }
}
