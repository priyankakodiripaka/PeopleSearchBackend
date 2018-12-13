namespace PeopleSearchBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeopleSearches", "Interests", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeopleSearches", "Interests");
        }
    }
}
