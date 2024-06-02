namespace WebApplication_CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inittest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Employees", "Salary", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
            DropTable("dbo.Students");
        }
    }
}
