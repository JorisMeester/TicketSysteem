namespace TicketSysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blep : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tickets", name: "Klant_Id", newName: "Customer_Id");
            RenameIndex(table: "dbo.Tickets", name: "IX_Klant_Id", newName: "IX_Customer_Id");
            CreateTable(
                "dbo.TicketReplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Reply = c.String(),
                        Ticket = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.Tickets", "Application", c => c.String());
            AddColumn("dbo.Tickets", "Subject", c => c.String());
            AddColumn("dbo.Tickets", "Description", c => c.String());
            AddColumn("dbo.Tickets", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tickets", "Replies_Id", c => c.Int());
            CreateIndex("dbo.Tickets", "Replies_Id");
            AddForeignKey("dbo.Tickets", "Replies_Id", "dbo.TicketReplies", "Id");
            DropColumn("dbo.Tickets", "Applicatie");
            DropColumn("dbo.Tickets", "Onderwerp");
            DropColumn("dbo.Tickets", "Omschrijving");
            DropColumn("dbo.Tickets", "Datum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Datum", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tickets", "Omschrijving", c => c.String());
            AddColumn("dbo.Tickets", "Onderwerp", c => c.String());
            AddColumn("dbo.Tickets", "Applicatie", c => c.String());
            DropForeignKey("dbo.Tickets", "Replies_Id", "dbo.TicketReplies");
            DropForeignKey("dbo.TicketReplies", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.TicketReplies", new[] { "User_Id" });
            DropIndex("dbo.Tickets", new[] { "Replies_Id" });
            DropColumn("dbo.Tickets", "Replies_Id");
            DropColumn("dbo.Tickets", "Date");
            DropColumn("dbo.Tickets", "Description");
            DropColumn("dbo.Tickets", "Subject");
            DropColumn("dbo.Tickets", "Application");
            DropTable("dbo.TicketReplies");
            RenameIndex(table: "dbo.Tickets", name: "IX_Customer_Id", newName: "IX_Klant_Id");
            RenameColumn(table: "dbo.Tickets", name: "Customer_Id", newName: "Klant_Id");
        }
    }
}
