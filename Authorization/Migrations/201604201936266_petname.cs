namespace Authorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class petname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PetName", c => c.String());
            DropColumn("dbo.AspNetUsers", "IsAwesome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "IsAwesome", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "PetName");
        }
    }
}
