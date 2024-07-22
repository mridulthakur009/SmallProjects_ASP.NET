namespace _7.WebApp_Country_State_City.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataToTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT Countries VALUES('India')");
            Sql("INSERT Countries VALUES('US')");
            Sql("INSERT Countries VALUES('UK')");

            Sql("INSERT States VALUES('Punjab',1)");
            Sql("INSERT States VALUES('HP',2)");
            Sql("INSERT States VALUES('UP',1)");
            Sql("INSERT States VALUES('UK',2)");

            Sql("INSERT Cities VALUES('Mohali',1)");
            Sql("INSERT Cities VALUES('Ludhiana',1)");
            Sql("INSERT Cities VALUES('Mandi',2)");
            Sql("INSERT Cities VALUES('Manali',2)");
            Sql("INSERT Cities VALUES('Mirzapur',3)");
            Sql("INSERT Cities VALUES('Azamgarh',3)");
            Sql("INSERT Cities VALUES('Dehradun',4)");
            Sql("INSERT Cities VALUES('Mussorie',4)");
        }
        
        public override void Down()
        {
        }
    }
}
