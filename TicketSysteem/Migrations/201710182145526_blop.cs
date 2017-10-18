namespace TicketSysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CustomerNumber", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Prefix", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            DropColumn("dbo.AspNetUsers", "Klantnummer");
            DropColumn("dbo.AspNetUsers", "Voornaam");
            DropColumn("dbo.AspNetUsers", "Tussenvoegsel");
            DropColumn("dbo.AspNetUsers", "Achternaam");
            DropColumn("dbo.AspNetUsers", "Telefoonnummer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Telefoonnummer", c => c.String());
            AddColumn("dbo.AspNetUsers", "Achternaam", c => c.String());
            AddColumn("dbo.AspNetUsers", "Tussenvoegsel", c => c.String());
            AddColumn("dbo.AspNetUsers", "Voornaam", c => c.String());
            AddColumn("dbo.AspNetUsers", "Klantnummer", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Prefix");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "CustomerNumber");
        }
    }
}
