namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class five : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.EmployeProjects", name: "Project_ProjectId", newName: "ProjectId");
        }

        public override void Down()
        {
            
        }
    }
}
