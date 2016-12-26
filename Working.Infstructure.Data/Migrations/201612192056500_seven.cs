namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seven : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmployeProjects", "wwwwwww");
        }
        
        public override void Down()
        {
        }
    }
}
