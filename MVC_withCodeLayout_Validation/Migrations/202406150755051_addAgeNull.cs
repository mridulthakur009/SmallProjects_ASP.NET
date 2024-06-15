namespace MVC_withCodeLayout_Validation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAgeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
    }
}
