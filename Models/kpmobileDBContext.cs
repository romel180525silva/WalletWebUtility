using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

namespace WalletWebUtility.Models
{
    [DbConfigurationType(typeof(MySqlConfiguration))]
    public class kpmobileDBContext : DbContext
    {
        public DbSet<device> devices { get; set; }
        public DbSet<MobileLogin> mobilelogin { get; set; }
        public DbSet<MobileAccounts> mobileAccounts { get; set; }
        public kpmobileDBContext()
      : base("name=MyContext")
        {

        }
        public kpmobileDBContext(DbConnection existingConnection, bool contextOwnsConnection)
   : base(existingConnection, contextOwnsConnection)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //   modelBuilder.Entity<device>().MapToStoredProcedures();
        }
    }
    [Table("device")]
    public class device
    {
        [Key]
        public string walletno { get; set; }
        public string deviceid { get; set; }
    }
    [Table("mobilelogin")]
    public class MobileLogin
    {
        [Key]
        public string walletno { get; set; }
        public string username { get; set; }
        public string custid { get; set; }
        public string password { get; set; }
        public string pincode { get; set; }
        public string mobileno { get; set; }
        public string emailaddress { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string birthdate { get; set; }
        public string nationality { get; set; }
        public string natureofwork { get; set; }
        public string provincecity { get; set; }
        public string permanentaddress { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public double Version { get; set; }
        public string secquestion1 { get; set; }
        public string secanswer1 { get; set; }
        public string secquestion2 { get; set; }
        public string secanswer2 { get; set; }
        public string secquestion3 { get; set; }
        public string secanswer3 { get; set; }
        public string WalletName { get; set; }


    }
    [Table("mobileaccounts")]
    public class MobileAccounts
    {
        [Key]
        public string walletno { get; set; }
        public decimal balance { get; set; }
        public decimal creditLimit { get; set; }
    }
}