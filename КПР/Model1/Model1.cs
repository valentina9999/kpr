namespace КПР
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AdDetails> AdDetails { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Realty> Realty { get; set; }
        public virtual DbSet<StatusRealty> StatusRealty { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeAd> TypeAd { get; set; }
        public virtual DbSet<TypeRealty> TypeRealty { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Phones)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.AdDetails)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ID_client_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Realty)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ID_client_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Realty>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Realty>()
                .HasMany(e => e.AdDetails)
                .WithRequired(e => e.Realty)
                .HasForeignKey(e => e.ID_realty_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusRealty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StatusRealty>()
                .HasMany(e => e.Realty)
                .WithRequired(e => e.StatusRealty)
                .HasForeignKey(e => e.ID_StatusRealty_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeAd>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TypeAd>()
                .HasMany(e => e.AdDetails)
                .WithRequired(e => e.TypeAd)
                .HasForeignKey(e => e.ID_typeAd_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeRealty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TypeRealty>()
                .HasMany(e => e.Realty)
                .WithRequired(e => e.TypeRealty)
                .HasForeignKey(e => e.ID_TypeRealty_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ID_user_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
