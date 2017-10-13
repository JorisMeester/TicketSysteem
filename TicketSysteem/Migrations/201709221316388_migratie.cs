namespace TicketSysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migratie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Applicatie = c.String(),
                        Onderwerp = c.String(),
                        Omschrijving = c.String(),
                        Datum = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Klant_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.Klant_Id)
                .Index(t => t.Klant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Klant_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "Klant_Id" });
            DropTable("dbo.Tickets");
        }
    }
}
