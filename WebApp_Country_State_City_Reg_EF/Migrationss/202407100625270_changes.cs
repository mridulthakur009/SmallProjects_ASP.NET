//namespace WebApp_Country_State_City_Reg_EF.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    public partial class changes : DbMigration
//    {
//        public override void Up()
//        {
//            DropForeignKey("dbo.States", "Country_Id", "dbo.Countries");
//            DropIndex("dbo.States", new[] { "Country_Id" });
//            RenameColumn(table: "dbo.States", name: "Country_Id", newName: "CountryId");
//            AlterColumn("dbo.States", "CountryId", c => c.Int(nullable: false));
//            CreateIndex("dbo.States", "CountryId");
//            AddForeignKey("dbo.States", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
//            DropColumn("dbo.States", "CouuntryId");
//        }
        
//        public override void Down()
//        {
//            AddColumn("dbo.States", "CouuntryId", c => c.Int(nullable: false));
//            DropForeignKey("dbo.States", "CountryId", "dbo.Countries");
//            DropIndex("dbo.States", new[] { "CountryId" });
//            AlterColumn("dbo.States", "CountryId", c => c.Int());
//            RenameColumn(table: "dbo.States", name: "CountryId", newName: "Country_Id");
//            CreateIndex("dbo.States", "Country_Id");
//            AddForeignKey("dbo.States", "Country_Id", "dbo.Countries", "Id");
//        }
//    }
//}
