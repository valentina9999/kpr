namespace КПР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            AdDetails = new HashSet<AdDetails>();
            Realty = new HashSet<Realty>();
        }

        [Required]
        [StringLength(50)]
        public string Phones { get; set; }

        [Required]
        [StringLength(50)]
        public string Passport { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [Key]
        public int ID_client { get; set; }

        public int ID_user_FK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdDetails> AdDetails { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Realty> Realty { get; set; }
    }
}
