namespace _6.MVC_MulTable_Val_MulLayout_PartialView_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToDepDsgModels : DbMigration
    {
        public override void Up()
        {
            //Inserting Data to Department Table
            Sql("INSERT INTO Departments VALUES('Angular')");
            Sql("INSERT INTO Departments VALUES('ReactJs')");
            Sql("INSERT INTO Departments VALUES('Dot NET')");
            Sql("INSERT INTO Departments VALUES('HR')");
            Sql("INSERT INTO Departments VALUES('Accounts')");
            Sql("INSERT INTO Departments VALUES('NodeJs')");
            Sql("INSERT INTO Departments VALUES('Python')");
            Sql("INSERT INTO Departments VALUES('Java')");

            //Inserting Data to Designation Table
            Sql("INSERT INTO Designations VALUES('Project Manager')");
            Sql("INSERT INTO Designations VALUES('Technical Lead')");
            Sql("INSERT INTO Designations VALUES('Team Lead')");
            Sql("INSERT INTO Designations VALUES('Sr. Software Associate')");
            Sql("INSERT INTO Designations VALUES('Software Associate')");

        }

        public override void Down()
        {
        }
    }
}
