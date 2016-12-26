namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class four : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.EmployeProjects", new[] { "Project_ProjectId" });
            //DropColumn("dbo.EmployeProjects", "ProjectId");
            //RenameColumn(table: "dbo.EmployeProjects", name: "Project_ProjectId", newName: "ProjectId");
            //DropPrimaryKey("dbo.EmployeProjects");
            //AlterColumn("dbo.EmployeProjects", "ProjectId", c => c.Int(nullable: false));
            //AddPrimaryKey("dbo.EmployeProjects", new[] { "EmployeId", "ProjectId" });
            //CreateIndex("dbo.EmployeProjects", "ProjectId");



            DropForeignKey("dbo.EmployeProjects",  "Project_ProjectId");
            DropForeignKey("dbo.EmployeProjects",  "Employe_EmployeId" );
            //DropColumn("dbo.EmployeProjects", "Project_ProjectId");
            //DropColumn("dbo.EmployeProjects", "Employe_EmployeId");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeProjects", "Project_ProjectId" );
            DropForeignKey("dbo.EmployeProjects", "Employe_EmployeId" );
            //DropColumn("dbo.EmployeProjects", "Project_ProjectId");
            //DropColumn("dbo.EmployeProjects", "Employe_EmployeId");





            //DropPrimaryKey("dbo.EmployeProjects");
            //AlterColumn("dbo.EmployeProjects", "ProjectId", c => c.Int(nullable: false, identity: true));
            //AddPrimaryKey("dbo.EmployeProjects", "ProjectId");
            //RenameColumn(table: "dbo.EmployeProjects", name: "ProjectId", newName: "Project_ProjectId");
            //AddColumn("dbo.EmployeProjects", "ProjectId", c => c.Int(nullable: false, identity: true));
            //CreateIndex("dbo.EmployeProjects", "Project_ProjectId");
        }
    }
}
