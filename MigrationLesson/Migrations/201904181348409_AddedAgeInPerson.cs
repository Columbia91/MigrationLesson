namespace MigrationLesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAgeInPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Age");
        }
    }
}
