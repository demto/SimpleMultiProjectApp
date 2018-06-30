namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonDtoSwap : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PersonDtoes");
            DropColumn("dbo.PersonDtoes", "Id");
            DropColumn("dbo.PersonDtoes", "TelNumber");
            AddColumn("dbo.PersonDtoes", "PersonDtos", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.PersonDtoes", "TelephoneNumber", c => c.String());
            AddPrimaryKey("dbo.PersonDtoes", "PersonDtos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonDtoes", "TelNumber", c => c.String());
            DropColumn("dbo.PersonDtoes", "TelephoneNumber");
            DropColumn("dbo.PersonDtoes", "PersonDtos");
            AddColumn("dbo.PersonDtoes", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.PersonDtoes");
            AddPrimaryKey("dbo.PersonDtoes", "Id");
        }
    }
}
