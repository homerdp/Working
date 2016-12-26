namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProjectEmployes", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ProjectEmployes", "Employe_EmployeId", "dbo.Employes");
            DropIndex("dbo.ProjectEmployes", new[] { "Project_ProjectId" });
            DropIndex("dbo.ProjectEmployes", new[] { "Employe_EmployeId" });
            CreateTable(
                "dbo.EmployeProjects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        EmployeId = c.Int(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        Project_ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Employes", t => t.EmployeId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId, cascadeDelete: true)
                .Index(t => t.EmployeId)
                .Index(t => t.Project_ProjectId);
            
            DropTable("dbo.ProjectEmployes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProjectEmployes",
                c => new
                    {
                        Project_ProjectId = c.Int(nullable: false),
                        Employe_EmployeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Project_ProjectId, t.Employe_EmployeId });
            
            DropForeignKey("dbo.EmployeProjects", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.EmployeProjects", "EmployeId", "dbo.Employes");
            DropIndex("dbo.EmployeProjects", new[] { "Project_ProjectId" });
            DropIndex("dbo.EmployeProjects", new[] { "EmployeId" });
            DropTable("dbo.EmployeProjects");
            CreateIndex("dbo.ProjectEmployes", "Employe_EmployeId");
            CreateIndex("dbo.ProjectEmployes", "Project_ProjectId");
            AddForeignKey("dbo.ProjectEmployes", "Employe_EmployeId", "dbo.Employes", "EmployeId", cascadeDelete: true);
            AddForeignKey("dbo.ProjectEmployes", "Project_ProjectId", "dbo.Projects", "ProjectId", cascadeDelete: true);
        }
    }
}
