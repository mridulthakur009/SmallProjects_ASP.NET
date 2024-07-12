namespace _7.WebApp_Country_State_City.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initLoad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        Subscribe = c.Boolean(nullable: false),
                        CityId = c.Int(nullable: false),
                        Country_Id = c.Int(),
                        State_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.States", t => t.State_Id)
                .Index(t => t.CityId)
                .Index(t => t.Country_Id)
                .Index(t => t.State_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registers", "State_Id", "dbo.States");
            DropForeignKey("dbo.Registers", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Registers", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "StateId", "dbo.States");
            DropForeignKey("dbo.States", "CountryId", "dbo.Countries");
            DropIndex("dbo.Registers", new[] { "State_Id" });
            DropIndex("dbo.Registers", new[] { "Country_Id" });
            DropIndex("dbo.Registers", new[] { "CityId" });
            DropIndex("dbo.States", new[] { "CountryId" });
            DropIndex("dbo.Cities", new[] { "StateId" });
            DropTable("dbo.Registers");
            DropTable("dbo.Countries");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
        }
    }
}
