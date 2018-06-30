namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SlightChangesOnTableCharacteristicsOfNewPersonDto : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PersonDtoes", newName: "PersonDtos");
            RenameColumn(table: "dbo.PersonDtos", name: "PersonDtos", newName: "PersonId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.PersonDtos", name: "PersonId", newName: "PersonDtos");
            RenameTable(name: "dbo.PersonDtos", newName: "PersonDtoes");
        }
    }
}
