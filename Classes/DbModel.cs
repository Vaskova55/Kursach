using Biblioteka2.Classes.Entityes;
using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace Biblioteka2.Classes
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbModel : DbContext
    {
        private static DbModel instance;
        public static DbModel init()
        {
            if (instance == null)
            {
                instance = new DbModel();
            }
            return instance;
        }
        // Your context has been configured to use a 'DbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Biblioteka2.Classes.DbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbModel' 
        // connection string in the application configuration file.
        public DbModel()
            : base("server=cfif31.ru;database=`ISPr21-33_VaskovaAN_Biblioteka`;" +
                  "user id=ISPr21-33_VaskovaAN;port=3306;characterset=utf8;password=KimBTSAlena5")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<BookClass> Books { get; set; }
        public virtual DbSet<PublisherClass> Publishers { get; set; }
        public virtual DbSet<TypeClass> Types { get; set; }
        public virtual DbSet<AuthorClass> Authors { get; set; }
        public virtual DbSet<TrainessClass> Trainesses { get; set; }
        public virtual DbSet<UserClass> Users { get; set; }
        public virtual DbSet<PurchaseAccountingClass> Purchase { get; set; }
        public virtual DbSet<IssuanceClass> Issuances { get; set; }
        public virtual DbSet<LiteratureTurnoverClass> LiteratureTurnover { get; set; }
        public virtual DbSet<PurchaseListClass> PurchaseLists { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}