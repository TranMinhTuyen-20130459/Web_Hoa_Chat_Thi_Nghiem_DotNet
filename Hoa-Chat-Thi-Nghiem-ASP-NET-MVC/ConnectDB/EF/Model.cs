namespace ConnectDB.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ShopHoaChat")
        {
        }

        public virtual DbSet<account_admin> account_admin { get; set; }
        public virtual DbSet<account_customer> account_customer { get; set; }
        public virtual DbSet<bill_detail> bill_detail { get; set; }
        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<comment_news> comment_news { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<infor_web> infor_web { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<price_product> price_product { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<role_admin> role_admin { get; set; }
        public virtual DbSet<sold_product> sold_product { get; set; }
        public virtual DbSet<status_acc> status_acc { get; set; }
        public virtual DbSet<status_bill> status_bill { get; set; }
        public virtual DbSet<status_product> status_product { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<type_product> type_product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account_customer>()
                .HasMany(e => e.bills)
                .WithRequired(e => e.account_customer)
                .HasForeignKey(e => e.id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<account_customer>()
                .HasMany(e => e.comment_news)
                .WithRequired(e => e.account_customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<bill>()
                .HasMany(e => e.bill_detail)
                .WithRequired(e => e.bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city>()
                .HasMany(e => e.account_customer)
                .WithRequired(e => e.city)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city>()
                .HasMany(e => e.bills)
                .WithRequired(e => e.city)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<news>()
                .HasMany(e => e.comment_news)
                .WithRequired(e => e.news)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.bill_detail)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.price_product)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.sold_product)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role_admin>()
                .HasMany(e => e.account_admin)
                .WithRequired(e => e.role_admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<status_acc>()
                .HasMany(e => e.account_admin)
                .WithRequired(e => e.status_acc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<status_acc>()
                .HasMany(e => e.account_customer)
                .WithRequired(e => e.status_acc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<status_bill>()
                .HasMany(e => e.bills)
                .WithRequired(e => e.status_bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<status_product>()
                .HasMany(e => e.products)
                .WithRequired(e => e.status_product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<supplier>()
                .HasMany(e => e.products)
                .WithRequired(e => e.supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<type_product>()
                .HasMany(e => e.products)
                .WithRequired(e => e.type_product)
                .WillCascadeOnDelete(false);
        }
    }
}
