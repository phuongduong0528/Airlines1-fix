namespace Airlines.Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix_table_useractivity_guid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserActivity", "Confidence", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserActivity", "Confidence", c => c.Guid());
        }
    }
}
