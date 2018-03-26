namespace Airlines.Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_table_useractivity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserActivity", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.UserActivity", "LogInTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserActivity", "LogInTime", c => c.Time(precision: 7));
            AlterColumn("dbo.UserActivity", "Date", c => c.DateTime(storeType: "date"));
        }
    }
}
