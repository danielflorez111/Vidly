namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdateInCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '20131201' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
